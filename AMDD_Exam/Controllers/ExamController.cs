using AMDD_Exam.Models;
using AMDD_Exam.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AMDD_Exam.Controllers
{
    public class ExamController : Controller
    {
        private readonly ExamService     _examService;
        private readonly SubmissionStore _store;

        // ── Reviewer password — change this to whatever you want ─────────
        private const string ReviewerPassword = "AMDD2026";

        public ExamController(ExamService examService, SubmissionStore store)
        {
            _examService = examService;
            _store       = store;
        }

        // ── Applicant: Start ─────────────────────────────────────────────
        public IActionResult Index()
            => View(new ExamStartViewModel());

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Start(ExamStartViewModel model)
        {
            if (!ModelState.IsValid) return View("Index", model);
            TempData["ApplicantName"] = model.ApplicantName;
            return RedirectToAction("Take");
        }

        // ── Applicant: Take exam ─────────────────────────────────────────
        public IActionResult Take()
        {
            string name = TempData.Peek("ApplicantName") as string;
            if (string.IsNullOrWhiteSpace(name)) return RedirectToAction("Index");

            // Record when exam started
            HttpContext.Session.SetString("ExamStart", DateTime.UtcNow.ToString("o"));

            ViewBag.ApplicantName = name;
            ViewBag.Skills        = SelfAssessSkills.Skills;
            return View(_examService.GetQuestions());
        }

        // ── Applicant: Submit ────────────────────────────────────────────
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Submit(
            string applicantName,
            Dictionary<int, int>    answers,
            Dictionary<int, string> openAnswers,
            Dictionary<string, int> selfRatings)
        {
            if (string.IsNullOrWhiteSpace(applicantName))
                return RedirectToAction("Index");

            var vm = new ExamSubmitViewModel
            {
                ApplicantName = applicantName,
                Answers       = answers     ?? new Dictionary<int, int>(),
                OpenAnswers   = openAnswers ?? new Dictionary<int, string>(),
                SelfRatings   = selfRatings ?? new Dictionary<string, int>()
            };

            var submission = _examService.Evaluate(vm);

            // Calculate time taken
            var startStr = HttpContext.Session.GetString("ExamStart");
            if (DateTime.TryParse(startStr, out DateTime startTime))
                submission.TimeTakenMins = (int)Math.Ceiling((DateTime.UtcNow - startTime).TotalMinutes);

            _store.Save(submission);

            return View("ThankYou", submission.ApplicantName);
        }

        // ── Reviewer: Login ──────────────────────────────────────────────
        public IActionResult ReviewerLogin()
            => View();

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ReviewerLogin(string password)
        {
            if (password == ReviewerPassword)
            {
                HttpContext.Session.SetString("ReviewerAuth", "true");
                return RedirectToAction("Results");
            }
            ViewBag.Error = "Incorrect password. Try again.";
            return View();
        }

        public IActionResult ReviewerLogout()
        {
            HttpContext.Session.Remove("ReviewerAuth");
            return RedirectToAction("Index");
        }

        // ── Reviewer: Guard ──────────────────────────────────────────────
        private bool IsReviewerAuthed()
            => HttpContext.Session.GetString("ReviewerAuth") == "true";

        // ── Reviewer: All submissions ────────────────────────────────────
        public IActionResult Results()
        {
            if (!IsReviewerAuthed()) return RedirectToAction("ReviewerLogin");
            return View(_store.GetAll());
        }

        // ── Reviewer: Detail ─────────────────────────────────────────────
        public IActionResult Review(Guid id)
        {
            if (!IsReviewerAuthed()) return RedirectToAction("ReviewerLogin");

            var submission = _store.GetById(id);
            if (submission == null) return NotFound();

            return View(new ReviewerDetailViewModel
            {
                Submission = submission,
                Questions  = _examService.GetQuestions()
            });
        }

        // ── Reviewer: Save notes + scores ────────────────────────────────
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SaveNotes(Guid id, string reviewerNotes,
            int codingScore = -1, int essayScore = -1)
        {
            if (!IsReviewerAuthed()) return RedirectToAction("ReviewerLogin");
            var submission = _store.GetById(id);
            if (submission == null) return NotFound();
            submission.ReviewerNotes      = reviewerNotes ?? "";
            submission.CodingReviewScore  = codingScore;
            submission.EssayReviewScore   = essayScore;
            _store.Save(submission);
            return RedirectToAction("Review", new { id });
        }
    }
}
