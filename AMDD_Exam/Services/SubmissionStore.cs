using AMDD_Exam.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace AMDD_Exam.Services
{
    public class SubmissionStore
    {
        private readonly string _filePath;
        private readonly object _lock = new object();
        private List<ExamSubmission> _cache;

        public SubmissionStore()
        {
            // Try multiple writable locations — works on Railway, Render, and local
            string dir = null;
            var candidates = new[]
            {
                Path.Combine(AppContext.BaseDirectory, "data"),
                Path.Combine(Path.GetTempPath(), "amdd_data"),
                "/tmp/amdd_data"
            };

            foreach (var candidate in candidates)
            {
                try
                {
                    Directory.CreateDirectory(candidate);
                    // Test write access
                    var testFile = Path.Combine(candidate, "test.tmp");
                    File.WriteAllText(testFile, "test");
                    File.Delete(testFile);
                    dir = candidate;
                    break;
                }
                catch { /* try next */ }
            }

            // Fallback: memory only (no persistence but won't crash)
            _filePath = dir != null ? Path.Combine(dir, "submissions.json") : null;
            _cache = Load();
        }

        public void Save(ExamSubmission submission)
        {
            lock (_lock)
            {
                var existing = _cache.FindIndex(s => s.Id == submission.Id);
                if (existing >= 0) _cache[existing] = submission;
                else _cache.Add(submission);
                Persist();
            }
        }

        public List<ExamSubmission> GetAll()
        {
            lock (_lock)
                return _cache.OrderByDescending(s => s.SubmittedAt).ToList();
        }

        public ExamSubmission GetById(Guid id)
        {
            lock (_lock)
                return _cache.FirstOrDefault(s => s.Id == id);
        }

        private List<ExamSubmission> Load()
        {
            try
            {
                if (_filePath != null && File.Exists(_filePath))
                {
                    var json = File.ReadAllText(_filePath);
                    return JsonSerializer.Deserialize<List<ExamSubmission>>(json)
                           ?? new List<ExamSubmission>();
                }
            }
            catch { }
            return new List<ExamSubmission>();
        }

        private void Persist()
        {
            try
            {
                if (_filePath == null) return;
                var json = JsonSerializer.Serialize(_cache,
                    new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
            catch { /* don't crash the app if file write fails */ }
        }
    }
}
