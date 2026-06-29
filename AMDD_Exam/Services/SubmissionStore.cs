using AMDD_Exam.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace AMDD_Exam.Services
{
    /// <summary>
    /// Singleton in-memory store. Holds all submissions for the app lifetime.
    /// </summary>
    public class SubmissionStore
    {
        private readonly ConcurrentDictionary<Guid, ExamSubmission> _store
            = new ConcurrentDictionary<Guid, ExamSubmission>();

        public void Save(ExamSubmission submission)
            => _store[submission.Id] = submission;

        public List<ExamSubmission> GetAll()
            => _store.Values.OrderByDescending(s => s.SubmittedAt).ToList();

        public ExamSubmission GetById(Guid id)
        {
            _store.TryGetValue(id, out ExamSubmission s);
            return s;
        }
    }
}
