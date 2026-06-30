using AMDD_Exam.Models;
using System.Collections.Generic;
using System.Linq;

namespace AMDD_Exam.Services
{
    public class ExamService
    {
        public List<ExamQuestion> GetQuestions() => new List<ExamQuestion>
        {
            // ════════════════════════════════════════════════════════════
            // PART A — C# (10 items)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=1, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which keyword is used to declare a class in C#?",
                Choices=new List<string>{ "object", "class", "new", "public" },
                CorrectIndex=1 },

            new ExamQuestion { Id=2, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What will be the output?\n---csharp\nint x = 10;\nint y = 3;\nConsole.WriteLine(x % y);",
                Choices=new List<string>{ "1", "3", "0", "10" },
                CorrectIndex=0 },

            new ExamQuestion { Id=3, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which collection type in C# automatically resizes as items are added?",
                Choices=new List<string>{ "Array", "List<T>", "Queue", "Tuple" },
                CorrectIndex=1 },

            new ExamQuestion { Id=4, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which keyword is used to catch and handle exceptions in C#?",
                Choices=new List<string>{ "if", "catch", "switch", "lock" },
                CorrectIndex=1 },

            new ExamQuestion { Id=5, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the purpose of an interface in C#?",
                Choices=new List<string>{
                    "Store data in memory",
                    "Define a contract that classes must implement",
                    "Create database tables",
                    "Declare global variables" },
                CorrectIndex=1 },

            new ExamQuestion { Id=6, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the output?\n---csharp\nstring name = \"Chelsea\";\nConsole.WriteLine(name.Length);",
                Choices=new List<string>{ "6", "7", "8", "Error" },
                CorrectIndex=2 },

            new ExamQuestion { Id=7, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the output?\n---csharp\nint x = 5;\nint y = x++;\nConsole.WriteLine(y);",
                Choices=new List<string>{ "6", "5", "4", "Compilation error" },
                CorrectIndex=1 },

            new ExamQuestion { Id=8, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which access modifier makes a member accessible ONLY within its own class?",
                Choices=new List<string>{ "public", "protected", "private", "internal" },
                CorrectIndex=2 },

            new ExamQuestion { Id=9, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the correct way to declare a nullable integer in C#?",
                Choices=new List<string>{ "int? x;", "nullable int x;", "int x = null;", "optional int x;" },
                CorrectIndex=0 },

            new ExamQuestion { Id=10, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What does the 'override' keyword do in C#?",
                Choices=new List<string>{
                    "Creates a new method unrelated to the base class",
                    "Provides a new implementation of a virtual method from the base class",
                    "Prevents a method from being inherited",
                    "Declares a method as static" },
                CorrectIndex=1 },

            // ════════════════════════════════════════════════════════════
            // PART B — SQL (8 items)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=11, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL statement retrieves ALL records from the Employees table?",
                Choices=new List<string>{
                    "SELECT * FROM Employees;",
                    "GET Employees;",
                    "SHOW Employees;",
                    "DISPLAY Employees;" },
                CorrectIndex=0 },

            new ExamQuestion { Id=12, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which query returns employees earning more than 50,000?\n\nTable: Employees (EmployeeID, Name, Department, Salary)",
                Choices=new List<string>{
                    "SELECT * FROM Employees WHERE Salary > 50000;",
                    "SELECT Salary > 50000;",
                    "GET Employees Salary > 50000;",
                    "SELECT FROM Employees;" },
                CorrectIndex=0 },

            new ExamQuestion { Id=13, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL clause combines matching rows from two tables?",
                Choices=new List<string>{ "UNION", "JOIN", "GROUP BY", "ORDER BY" },
                CorrectIndex=1 },

            new ExamQuestion { Id=14, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL function counts the number of records?",
                Choices=new List<string>{ "SUM()", "COUNT()", "AVG()", "MAX()" },
                CorrectIndex=1 },

            new ExamQuestion { Id=15, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which query correctly sorts employees by salary from HIGHEST to LOWEST?",
                Choices=new List<string>{
                    "ORDER Salary DESC",
                    "SORT Salary DESC",
                    "SELECT * FROM Employees ORDER BY Salary DESC;",
                    "SELECT Salary DESC;" },
                CorrectIndex=2 },

            new ExamQuestion { Id=16, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL statement MODIFIES existing records in a table?",
                Choices=new List<string>{ "INSERT", "CREATE", "DELETE", "UPDATE" },
                CorrectIndex=3 },

            new ExamQuestion { Id=17, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the difference between WHERE and HAVING in SQL?",
                Choices=new List<string>{
                    "They are identical",
                    "WHERE filters rows before grouping; HAVING filters after GROUP BY",
                    "HAVING works only on text columns",
                    "WHERE is only for SELECT; HAVING is for INSERT" },
                CorrectIndex=1 },

            new ExamQuestion { Id=18, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL keyword removes duplicate rows from a result set?",
                Choices=new List<string>{ "UNIQUE", "DISTINCT", "FILTER", "REMOVE" },
                CorrectIndex=1 },

            // ════════════════════════════════════════════════════════════
            // PART C — HTML / CSS (4 items)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=19, Section="CSS", Type="mcq", Dimension=Dimension.Dev,
                Text="Which CSS property changes the text color of an element?",
                Choices=new List<string>{ "font-color", "text-color", "color", "foreground" },
                CorrectIndex=2 },

            new ExamQuestion { Id=20, Section="CSS", Type="mcq", Dimension=Dimension.Dev,
                Text="Which CSS display value makes elements sit side by side and allows setting width and height?",
                Choices=new List<string>{ "block", "inline", "inline-block", "flex" },
                CorrectIndex=2 },

            new ExamQuestion { Id=21, Section="CSS", Type="mcq", Dimension=Dimension.Dev,
                Text="Which HTML tag is used to link an external CSS file?",
                Choices=new List<string>{
                    "<style src=\"file.css\">",
                    "<link rel=\"stylesheet\" href=\"file.css\">",
                    "<css href=\"file.css\">",
                    "<script src=\"file.css\">" },
                CorrectIndex=1 },

            new ExamQuestion { Id=22, Section="CSS", Type="mcq", Dimension=Dimension.Dev,
                Text="In CSS Flexbox, which property aligns items along the MAIN axis?",
                Choices=new List<string>{ "align-items", "justify-content", "flex-wrap", "align-self" },
                CorrectIndex=1 },

            // ════════════════════════════════════════════════════════════
            // PART D — REST API (4 items)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=23, Section="API", Type="mcq", Dimension=Dimension.Dev,
                Text="What HTTP method is used to CREATE a new resource via a REST API?",
                Choices=new List<string>{ "GET", "DELETE", "PUT", "POST" },
                CorrectIndex=3 },

            new ExamQuestion { Id=24, Section="API", Type="mcq", Dimension=Dimension.Dev,
                Text="Which HTTP status code means the request was successful and a resource was created?",
                Choices=new List<string>{ "200 OK", "201 Created", "404 Not Found", "500 Internal Server Error" },
                CorrectIndex=1 },

            new ExamQuestion { Id=25, Section="API", Type="mcq", Dimension=Dimension.Dev,
                Text="Which data format is most commonly used when exchanging data between a frontend and a REST API?",
                Choices=new List<string>{ "XML only", "CSV", "JSON", "PDF" },
                CorrectIndex=2 },

            new ExamQuestion { Id=26, Section="API", Type="mcq", Dimension=Dimension.Dev,
                Text="In ASP.NET Core Web API, which attribute marks a method to handle HTTP GET requests?",
                Choices=new List<string>{ "[Post]", "[HttpGet]", "[Route(\"GET\")]", "[Get()]" },
                CorrectIndex=1 },

            // ════════════════════════════════════════════════════════════
            // PART E — ATTITUDE / BEHAVIORAL (5 items)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=27, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A task is assigned with a 2-hour deadline but the requirements are unclear. What do you do?",
                Choices=new List<string>{
                    "Start working based on your own assumptions",
                    "Immediately ask your team lead to clarify, then work as efficiently as possible",
                    "Ignore it since unclear requirements are not your problem",
                    "Wait until requirements are 100% clear even if the deadline passes" },
                CorrectIndex=1 },

            new ExamQuestion { Id=28, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A colleague points out a mistake in your code during a code review. How do you respond?",
                Choices=new List<string>{
                    "Defend your code and argue it is correct",
                    "Thank them, understand the issue, fix it, and learn from the feedback",
                    "Feel offended and stop attending future reviews",
                    "Blame the requirements document" },
                CorrectIndex=1 },

            new ExamQuestion { Id=29, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="You discover a critical bug in production on Friday at 4:30 PM. What is your action?",
                Choices=new List<string>{
                    "Log off and deal with it Monday",
                    "Immediately inform your team lead, assess the impact, and collaborate on a fix or rollback",
                    "Hide the bug and hope no one notices",
                    "Send an email and wait for a reply next week" },
                CorrectIndex=1 },

            new ExamQuestion { Id=30, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="Your team is assigned a project using a technology stack you have never used. What is your approach?",
                Choices=new List<string>{
                    "Refuse the project until given a familiar stack",
                    "Proactively study the new stack, ask for guidance, and apply it step by step",
                    "Copy-paste code from the internet without understanding it",
                    "Tell the manager it is impossible" },
                CorrectIndex=1 },

            new ExamQuestion { Id=31, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A feature works on your local machine but fails in production. What is your FIRST action?",
                Choices=new List<string>{
                    "Rewrite the whole application from scratch",
                    "Restart the production server repeatedly",
                    "Review logs, compare environment configurations, and reproduce the issue before fixing",
                    "Roll back all recent code without investigation" },
                CorrectIndex=2 },

            // ════════════════════════════════════════════════════════════
            // PART F — CODING CHALLENGES (7 items: C#, SQL, CSS, API)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=32, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="C#: Write a method that accepts an integer and returns true if the number is EVEN, otherwise false.",
                CodingPrompt="Example:\n  IsEven(4) → true\n  IsEven(7) → false",
                CodingLanguageHint="C#" },

            new ExamQuestion { Id=33, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="C# Debugging: Explain the error in this code and write the corrected version.\n---csharp\nint number = \"10\";\nConsole.WriteLine(number);",
                CodingPrompt="1. Why does this fail to compile?\n2. Write the corrected code.",
                CodingLanguageHint="C#" },

            new ExamQuestion { Id=34, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="C# Debugging: This loop never terminates. Explain why and write the corrected version.\n---csharp\nfor (int i = 0; i <= 5; i--)\n{\n    Console.WriteLine(i);\n}",
                CodingPrompt="1. Explain why the loop never stops.\n2. Write the corrected loop.",
                CodingLanguageHint="C#" },

            new ExamQuestion { Id=35, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="SQL: Write a SELECT statement that returns all employees in the 'IT' department.\n\nTable: Employees (EmployeeID, Name, Department, Salary)",
                CodingPrompt="Write your SQL query below.",
                CodingLanguageHint="SQL" },

            new ExamQuestion { Id=36, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="SQL JOIN: Write a query to display CustomerName, OrderID, and OrderDate.\n\nCustomers (CustomerID, CustomerName)\nOrders    (OrderID, CustomerID, OrderDate)",
                CodingPrompt="Use the correct JOIN type to combine both tables.",
                CodingLanguageHint="SQL" },

            new ExamQuestion { Id=37, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="CSS: Write CSS code to make a div element:\n  - Background color: purple (#6a1fa3)\n  - Text color: white\n  - Padding: 16px\n  - Border radius: 8px\n  - Centered horizontally on the page using Flexbox",
                CodingPrompt="Write the CSS for the container and the div.",
                CodingLanguageHint="CSS" },

            new ExamQuestion { Id=38, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="REST API: Using JavaScript fetch(), write code that calls this API endpoint and logs the result to the console.\n\n  GET https://api.example.com/employees",
                CodingPrompt="Use fetch() with async/await or .then(). Handle the JSON response.",
                CodingLanguageHint="JavaScript / REST API" },

            // ════════════════════════════════════════════════════════════
            // PART G — ESSAY (2 items)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=39, Section="Essay", Type="essay", Dimension=Dimension.Dev,
                Text="Describe your technical skills and experience.",
                EssayBullets="• Programming languages you know (C#, Java, Python, etc.)\n• Frameworks and tools (ASP.NET, Git, REST APIs, etc.)\n• Databases you have worked with\n• Where you learned these skills\n• A project where you applied them" },

            new ExamQuestion { Id=40, Section="Essay", Type="essay", Dimension=Dimension.Dev,
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
                if (q.Type == "essay") continue;

                bool correct = vm.Answers.TryGetValue(q.Id, out int ans) && ans == q.CorrectIndex;
                switch (q.Dimension)
                {
                    case Dimension.Support: suppMax++;  if (correct) suppScore++; break;
                    case Dimension.Dev:     devMax++;   if (correct) devScore++;  break;
                    case Dimension.Attitude:attMax++;   if (correct) attScore++;  break;
                }
            }

            double devPct  = devMax  > 0 ? (double)devScore  / devMax  : 0;
            double attPct  = attMax  > 0 ? (double)attScore  / attMax  : 0;
            double codPct  = codingTotal > 0 ? (double)codingAttempted / codingTotal : 0;

            ResultClassification classification;
            if (attPct < 0.60)
                classification = ResultClassification.NotAFit;
            else if (devPct >= 0.60 && codPct >= 0.50)
                classification = ResultClassification.Developer;
            else if (devPct >= 0.40)
                classification = ResultClassification.Support;
            else
                classification = ResultClassification.NotAFit;

            string remarks = classification == ResultClassification.Developer
                ? "Strong technical knowledge across C#, SQL, CSS, and REST APIs — combined with a positive work attitude and solid coding challenge participation. Clear potential as a Software Developer for AMDD."
                : classification == ResultClassification.Support
                    ? "Moderate technical knowledge with good work attitude. Candidate may be suited for an IT Support or junior developer role within the team."
                    : "Results do not sufficiently align with the Developer or IT Support profile at this time. Encourage the applicant to build their skills and apply again.";

            return new ExamSubmission
            {
                ApplicantName   = vm.ApplicantName,
                Answers         = vm.Answers,
                OpenAnswers     = vm.OpenAnswers,
                SelfRatings     = vm.SelfRatings,
                SupportScore    = suppScore,
                SupportMax      = suppMax,
                DevScore        = devScore,
                DevMax          = devMax,
                AttitudeScore   = attScore,
                AttitudeMax     = attMax,
                CodingAttempted = codingAttempted,
                CodingTotal     = codingTotal,
                Classification  = classification,
                Remarks         = remarks
            };
        }
    }
}
