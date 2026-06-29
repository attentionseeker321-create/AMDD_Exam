using AMDD_Exam.Models;
using System.Collections.Generic;
using System.Linq;

namespace AMDD_Exam.Services
{
    public class ExamService
    {
        // ── Question Bank ────────────────────────────────────────────────
        // Section is INTERNAL — applicant only sees question numbers.
        // Questions are returned in a MIXED order so applicant cannot tell
        // which are support vs dev vs attitude.
        // ────────────────────────────────────────────────────────────────
        public List<ExamQuestion> GetQuestions() => new List<ExamQuestion>
        {
            // ── IT Support Scenarios (Dimension.Support) ─────────────────
            new ExamQuestion { Id=1,  Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="A user submits a request to access ATM Transaction Reports for all branch TIDs. What should you verify FIRST?",
                Choices=new List<string>{
                    "Immediately generate the reports without checking anything",
                    "Verify the requester, business unit, report type, branch, and whether approval is completed",
                    "Forward directly to the database team without reviewing",
                    "Close the ticket and ask the user to resubmit"},
                CorrectIndex=1 },

            new ExamQuestion { Id=2, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="You are processing an ATM report request but the requester forgot to include the TID. What do you do?",
                Choices=new List<string>{
                    "Guess the TID based on the branch name",
                    "Reject the request immediately without explanation",
                    "Contact the requester and ask for the missing TID before processing",
                    "Generate reports for every TID in the system"},
                CorrectIndex=2 },

            new ExamQuestion { Id=3, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="A Work Order ticket is approaching an SLA breach. What should you do?",
                Choices=new List<string>{
                    "Ignore it and continue with lower-priority tasks",
                    "Monitor the SLA, prioritize the ticket, update the requester, and escalate if necessary",
                    "Close the ticket to stop the SLA timer",
                    "Wait for someone else on the team to notice"},
                CorrectIndex=1 },

            new ExamQuestion { Id=4, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="A request arrives assigned to the wrong support group. What should you do?",
                Choices=new List<string>{
                    "Work on it anyway even though it is not your responsibility",
                    "Reassign it to the correct support group with proper notes",
                    "Delete the ticket",
                    "Close it without informing anyone"},
                CorrectIndex=1 },

            new ExamQuestion { Id=5, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="A requester asks for an ATM report but only ECOD has permission to generate it. What do you do?",
                Choices=new List<string>{
                    "Attempt to generate it anyway to save time",
                    "Coordinate with ECOD and update the requester on the status",
                    "Close the request without notifying the requester",
                    "Ignore the request"},
                CorrectIndex=1 },

            new ExamQuestion { Id=6, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="In a standard ticket workflow, which status usually comes after \"Assigned\"?",
                Choices=new List<string>{ "Closed", "Completed", "In Progress", "Cancelled" },
                CorrectIndex=2 },

            new ExamQuestion { Id=7, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="A user reports: \"Cannot delete a DBP One registration.\" What is your FIRST action?",
                Choices=new List<string>{
                    "Delete the records directly from the database immediately",
                    "Gather the error message, verify application behavior, check knowledge articles, and coordinate with the responsible team if needed",
                    "Restart your PC",
                    "Close the ticket and tell the user to try again later"},
                CorrectIndex=1 },

            new ExamQuestion { Id=8, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="A customer follows up: \"I still cannot access the report.\" What should you do?",
                Choices=new List<string>{
                    "Ignore the follow-up since the ticket was already resolved",
                    "Verify whether the report was generated correctly, validate permissions or shared folder access, and respond with findings",
                    "Close the ticket again",
                    "Forward to another team without checking first"},
                CorrectIndex=1 },

            new ExamQuestion { Id=9, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="What information should always be included in a work log entry?",
                Choices=new List<string>{
                    "Only the word \"Done.\"",
                    "Actions performed, findings, coordination made, current status, and next steps",
                    "Nothing — work logs are optional",
                    "Only your personal opinion"},
                CorrectIndex=1 },

            new ExamQuestion { Id=10, Section="Support", Type="mcq", Dimension=Dimension.Support,
                Text="A ticket requires approval before processing. What should you do?",
                Choices=new List<string>{
                    "Process it immediately to avoid delays",
                    "Wait until approval is completed, following the approval process per company policy",
                    "Close the ticket since it cannot be processed yet",
                    "Reject the request and ask the user to resubmit"},
                CorrectIndex=1 },

            // ── Security (Dimension.Support) ─────────────────────────────
            new ExamQuestion { Id=11, Section="Security", Type="mcq", Dimension=Dimension.Support,
                Text="A user receives an email asking for their banking application password, claiming it is from IT. What should the user do?",
                Choices=new List<string>{
                    "Reply immediately with their password",
                    "Share the password only if the email looks official",
                    "Report the email as phishing and do not click any links",
                    "Forward it to everyone in the office"},
                CorrectIndex=2 },

            new ExamQuestion { Id=12, Section="Security", Type="mcq", Dimension=Dimension.Support,
                Text="What is Multi-Factor Authentication (MFA)?",
                Choices=new List<string>{
                    "Using two different passwords",
                    "A type of antivirus software",
                    "Verifying identity using two or more authentication factors (e.g. password + OTP)",
                    "Encrypting files on a hard drive"},
                CorrectIndex=2 },

            new ExamQuestion { Id=13, Section="Security", Type="mcq", Dimension=Dimension.Support,
                Text="Which of the following is the STRONGEST password?",
                Choices=new List<string>{ "Password123", "Chelsea2026", "Welcome1", "T#8vP!9x@Lm2" },
                CorrectIndex=3 },

            // ── Development Technical (Dimension.Dev) ────────────────────
            new ExamQuestion { Id=14, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the primary purpose of Git?",
                Choices=new List<string>{
                    "To edit images and design assets",
                    "To track changes in source code and collaborate with other developers",
                    "To compile C# applications",
                    "To manage Windows updates"},
                CorrectIndex=1 },

            new ExamQuestion { Id=15, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="What HTTP method is commonly used to CREATE a new resource via an API?",
                Choices=new List<string>{ "GET", "DELETE", "PUT", "POST" },
                CorrectIndex=3 },

            new ExamQuestion { Id=16, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="Which data format is most commonly used when exchanging data between a frontend and backend API?",
                Choices=new List<string>{ "XML only", "CSV", "JSON", "PDF" },
                CorrectIndex=2 },

            new ExamQuestion { Id=17, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL statement is used to MODIFY existing records in a table?",
                Choices=new List<string>{ "INSERT", "CREATE", "DELETE", "UPDATE" },
                CorrectIndex=3 },

            new ExamQuestion { Id=18, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the output of this C# snippet?\n\nint a = 10;\nint b = 20;\nConsole.WriteLine(a + b);",
                Choices=new List<string>{ "10", "20", "1020", "30" },
                CorrectIndex=3 },

            new ExamQuestion { Id=19, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the output of this C# snippet?\n\nint x = 5;\nint y = x++;\nConsole.WriteLine(y);",
                Choices=new List<string>{ "6", "5", "4", "Compilation error" },
                CorrectIndex=1 },

            new ExamQuestion { Id=20, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="In SQL, what is the difference between WHERE and HAVING?",
                Choices=new List<string>{
                    "They are identical; HAVING is just an alias for WHERE",
                    "WHERE filters rows before grouping; HAVING filters after GROUP BY aggregation",
                    "HAVING works only on text columns; WHERE works only on numeric columns",
                    "WHERE is for SELECT only; HAVING is for INSERT statements"},
                CorrectIndex=1 },

            new ExamQuestion { Id=21, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="In ASP.NET Core MVC, what is the role of the Controller?",
                Choices=new List<string>{
                    "It holds the database connection string",
                    "It defines the HTML markup and styling of the page",
                    "It handles incoming HTTP requests, processes logic, and returns a response or view",
                    "It is only used for authentication middleware"},
                CorrectIndex=2 },

            new ExamQuestion { Id=22, Section="Dev", Type="mcq", Dimension=Dimension.Dev,
                Text="A feature works on your local machine but fails in production. What is your FIRST action?",
                Choices=new List<string>{
                    "Rewrite the whole application from scratch",
                    "Restart the production server repeatedly",
                    "Review logs, compare environment configurations, and reproduce the issue before applying a fix",
                    "Roll back all recent code without any investigation"},
                CorrectIndex=2 },

            // ── Attitude / Behavioral (Dimension.Attitude) ───────────────
            new ExamQuestion { Id=23, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A task is assigned with a 2-hour deadline but the requirements are unclear. What do you do?",
                Choices=new List<string>{
                    "Start working based on your own assumptions",
                    "Immediately ask your team lead to clarify key points, then work as efficiently as possible",
                    "Ignore the task since unclear requirements are not your problem",
                    "Wait until the requirements are 100% clear even if the deadline passes"},
                CorrectIndex=1 },

            new ExamQuestion { Id=24, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A colleague points out a mistake in your code during a code review. How do you respond?",
                Choices=new List<string>{
                    "Defend your code and argue it is correct",
                    "Thank them, understand the issue, fix it, and learn from the feedback",
                    "Feel offended and stop attending future reviews",
                    "Blame the requirements document"},
                CorrectIndex=1 },

            new ExamQuestion { Id=25, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="You discover a critical bug in production on Friday at 4:30 PM. What is your action?",
                Choices=new List<string>{
                    "Log off and deal with it Monday",
                    "Immediately inform your team lead, assess the impact, and collaborate on a fix or rollback",
                    "Hide the bug and hope no one notices",
                    "Send an email and wait for a reply next week"},
                CorrectIndex=1 },

            new ExamQuestion { Id=26, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="Your team is assigned a project using a technology stack you have never used. What is your approach?",
                Choices=new List<string>{
                    "Refuse the project until given a familiar stack",
                    "Proactively study the new stack, ask for guidance, and apply it step by step",
                    "Copy-paste code from the internet without understanding it",
                    "Tell the manager it is impossible"},
                CorrectIndex=1 },

            new ExamQuestion { Id=27, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A user keeps calling about the same issue you already resolved. How do you handle it?",
                Choices=new List<string>{
                    "Tell them you already fixed it and hang up",
                    "Patiently re-investigate, walk them through it, and document the resolution properly",
                    "Transfer them to another team without explanation",
                    "Ignore their calls from that point on"},
                CorrectIndex=1 },

            // ── Coding Challenges (3 only) ────────────────────────────────
            new ExamQuestion { Id=28, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="Write a function that accepts an integer array and returns the sum of all EVEN numbers.",
                CodingPrompt="Example:\n  Input:  [1, 2, 3, 4, 5, 6]\n  Output: 12\n\nUse any language: C#, Java, Python, or pseudocode.",
                CodingLanguageHint="C#, Java, Python, or pseudocode" },

            new ExamQuestion { Id=29, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="Write a SQL query for the table below.\n\nTable: ATM_Reports (TID, Branch, ReportDate, GeneratedBy, Status)\n\nReturn all reports generated today for the 'SAN FERNANDO LA UNION' branch.",
                CodingPrompt="Expected answer uses CAST(GETDATE() AS DATE) or equivalent.\nWrite a SELECT statement.",
                CodingLanguageHint="SQL" },

            new ExamQuestion { Id=30, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="The following code has a bug. Explain the problem and write the corrected version.\n\nfor (int i = 0; i <= 5; i--)\n{\n    Console.WriteLine(i);\n}",
                CodingPrompt="Why does this code never terminate?\nExplain the bug AND write the corrected loop.",
                CodingLanguageHint="C# — explanation + corrected code" },

            // ── Essay Questions (2) ───────────────────────────────────────
            new ExamQuestion { Id=31, Section="Essay", Type="essay", Dimension=Dimension.Dev,
                Text="Describe your technical skills and experience.",
                EssayBullets="• Programming languages you know (C#, Java, Python, etc.)\n• Frameworks and tools (ASP.NET, Git, REST APIs, etc.)\n• Databases you have worked with\n• Where you learned these skills\n• A project where you applied them" },

            new ExamQuestion { Id=32, Section="Essay", Type="essay", Dimension=Dimension.Dev,
                Text="What software project are you most proud of? Describe it in detail.",
                EssayBullets="• Purpose of the project\n• Technologies used\n• Your specific contribution\n• Biggest challenge you faced\n• What you would improve in the future" },
        };

        // ── Evaluate & Classify ──────────────────────────────────────────
        public ExamSubmission Evaluate(ExamSubmitViewModel vm)
        {
            var questions = GetQuestions().ToDictionary(q => q.Id);

            int suppScore = 0, suppMax = 0;
            int devScore  = 0, devMax  = 0;
            int attScore  = 0, attMax  = 0;
            int codingAttempted = 0, codingTotal = 0;

            foreach (var q in questions.Values)
            {
                if (q.Type == "code")
                {
                    codingTotal++;
                    if (vm.OpenAnswers.TryGetValue(q.Id, out string code)
                        && !string.IsNullOrWhiteSpace(code))
                        codingAttempted++;
                    continue;
                }
                if (q.Type == "essay") continue; // not auto-scored

                // MCQ scoring
                bool correct = vm.Answers.TryGetValue(q.Id, out int ans) && ans == q.CorrectIndex;
                switch (q.Dimension)
                {
                    case Dimension.Support: suppMax++;  if (correct) suppScore++; break;
                    case Dimension.Dev:     devMax++;   if (correct) devScore++;  break;
                    case Dimension.Attitude:attMax++;   if (correct) attScore++;  break;
                }
            }

            double suppPct = suppMax  > 0 ? (double)suppScore / suppMax  : 0;
            double devPct  = devMax   > 0 ? (double)devScore  / devMax   : 0;
            double attPct  = attMax   > 0 ? (double)attScore  / attMax   : 0;
            double codPct  = codingTotal > 0 ? (double)codingAttempted / codingTotal : 0;

            ResultClassification classification;
            if (attPct < 0.60)
                classification = ResultClassification.NotAFit;
            else if (devPct >= 0.60 && codPct >= 0.50)
                classification = ResultClassification.Developer;
            else if (suppPct >= 0.60)
                classification = ResultClassification.Support;
            else if (devPct >= 0.60)
                classification = suppPct >= 0.40
                    ? ResultClassification.Support
                    : ResultClassification.NotAFit;
            else
                classification = ResultClassification.NotAFit;

            string remarks = classification == ResultClassification.Developer
                ? "Strong development technical knowledge, positive work attitude, and active participation in coding challenges. Candidate shows clear potential as a Software Developer for AMDD."
                : classification == ResultClassification.Support
                    ? "Good grasp of IT support fundamentals — ticketing, workflows, security, and service desk scenarios — combined with a positive work attitude. Candidate is suited for an IT Support role."
                    : "Results do not sufficiently align with either a Developer or IT Support profile at this time. Encourage the applicant to build their skills and apply again.";

            return new ExamSubmission
            {
                ApplicantName  = vm.ApplicantName,
                Answers        = vm.Answers,
                OpenAnswers    = vm.OpenAnswers,
                SelfRatings    = vm.SelfRatings,
                SupportScore   = suppScore,
                SupportMax     = suppMax,
                DevScore       = devScore,
                DevMax         = devMax,
                AttitudeScore  = attScore,
                AttitudeMax    = attMax,
                CodingAttempted = codingAttempted,
                CodingTotal    = codingTotal,
                Classification = classification,
                Remarks        = remarks
            };
        }
    }
}
