using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AMDD_Exam.Models
{
    public enum Dimension { Support, Dev, Attitude }

    public class ExamQuestion
    {
        public int    Id                 { get; set; }
        public string Section            { get; set; }  // internal — NEVER shown to applicant
        public string Text               { get; set; }
        public string Type               { get; set; }  // "mcq" | "code" | "essay"
        public List<string> Choices      { get; set; }  // MCQ only
        public int    CorrectIndex       { get; set; } = -1;
        public Dimension Dimension       { get; set; }
        public string CodingPrompt       { get; set; }
        public string CodingLanguageHint { get; set; }
        public string EssayBullets       { get; set; }  // newline-separated hints for essay
    }

    public static class SelfAssessSkills
    {
        public static readonly List<string> Skills = new List<string>
        {
            "C#", "Java", "Python", "SQL", "ASP.NET MVC / Core",
            "REST API Development", "HTML / CSS", "JavaScript",
            "Git", "Object-Oriented Programming",
            "Database Design", "Debugging",
            "Network Troubleshooting", "IT Support / Ticketing"
        };
    }

    // ── Applicant start form ──────────────────────────────────────────
    public class ExamStartViewModel
    {
        [Required(ErrorMessage = "Please enter your full name.")]
        [Display(Name = "Full Name")]
        public string ApplicantName { get; set; }
    }

    // ── Raw form post (what the browser sends) ────────────────────────
    public class ExamSubmitViewModel
    {
        [Required]
        public string ApplicantName { get; set; }

        // MCQ: key = question Id, value = chosen index (0-based)
        public Dictionary<int, int> Answers { get; set; } = new Dictionary<int, int>();

        // Coding + Essay: key = question Id, value = typed text
        public Dictionary<int, string> OpenAnswers { get; set; } = new Dictionary<int, string>();

        // Self-assessment: key = skill name, value = 1-5
        public Dictionary<string, int> SelfRatings { get; set; } = new Dictionary<string, int>();
    }

    // ── Persisted submission (reviewer sees this) ─────────────────────
    public class ExamSubmission
    {
        public Guid     Id            { get; set; } = Guid.NewGuid();
        public string   ApplicantName { get; set; }
        public DateTime SubmittedAt   { get; set; } = DateTime.Now;

        public Dictionary<int, int>    Answers     { get; set; }
        public Dictionary<int, string> OpenAnswers { get; set; }
        public Dictionary<string, int> SelfRatings { get; set; }

        // Computed
        public int SupportScore    { get; set; }
        public int SupportMax      { get; set; }
        public int DevScore        { get; set; }
        public int DevMax          { get; set; }
        public int AttitudeScore   { get; set; }
        public int AttitudeMax     { get; set; }
        public int CodingAttempted { get; set; }
        public int CodingTotal     { get; set; }

        public ResultClassification Classification { get; set; }
        public string Remarks { get; set; }
        public string ReviewerNotes { get; set; } = "";

        public int SupportPct  => SupportMax  > 0 ? (int)((SupportScore  / (double)SupportMax)  * 100) : 0;
        public int DevPct      => DevMax      > 0 ? (int)((DevScore      / (double)DevMax)      * 100) : 0;
        public int AttitudePct => AttitudeMax > 0 ? (int)((AttitudeScore / (double)AttitudeMax) * 100) : 0;
        public int CodingPct   => CodingTotal > 0 ? (int)((CodingAttempted / (double)CodingTotal) * 100) : 0;

        public string ClassificationLabel =>
            Classification == ResultClassification.Developer ? "💻 Software Developer" :
            Classification == ResultClassification.Support   ? "🛠️ IT Support" : "❌ Not a Fit";

        public string ClassificationColor =>
            Classification == ResultClassification.Developer ? "success" :
            Classification == ResultClassification.Support   ? "info"    : "danger";
    }

    public enum ResultClassification { Developer, Support, NotAFit }

    // ── Reviewer view models ──────────────────────────────────────────
    public class ReviewerDetailViewModel
    {
        public ExamSubmission      Submission { get; set; }
        public List<ExamQuestion>  Questions  { get; set; }
    }
}
