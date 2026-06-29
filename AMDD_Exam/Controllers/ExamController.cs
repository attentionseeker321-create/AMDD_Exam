using AMDD_Exam.Models;
using AMDD_Exam.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AMDD_Exam.Controllers
{
    public class ExamController : Controller
    {
        private readonly ExamService     _examService;
        private readonly SubmissionStore _store;

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
            _store.Save(submission);

            // Applicant only sees a thank-you page — no scores shown
            return View("ThankYou", submission.ApplicantName);
        }

        // ── Reviewer: List all submissions ───────────────────────────────
        // URL: /Exam/Results
        public IActionResult Results()
            => View(_store.GetAll());

        // ── Reviewer: Save notes ─────────────────────────────────────────
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SaveNotes(Guid id, string reviewerNotes)
        {
            var submission = _store.GetById(id);
            if (submission == null) return NotFound();
            submission.ReviewerNotes = reviewerNotes ?? "";
            return RedirectToAction("Review", new { id });
        }
        public IActionResult Review(Guid id)
        {
            var submission = _store.GetById(id);
            if (submission == null) return NotFound();

            return View(new ReviewerDetailViewModel
            {
                Submission = submission,
                Questions  = _examService.GetQuestions()
            });
        }
    }
}
