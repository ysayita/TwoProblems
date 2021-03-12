using ProblemBase;
using System;
using System.Linq;

namespace SequenceAnalysis
{
    public class SequenceAnalysisProblem : IProblem
    {
        private SequenceAnalysisProblem() { }
        private static readonly Lazy<SequenceAnalysisProblem> lazyInstance = new Lazy<SequenceAnalysisProblem>(() => new SequenceAnalysisProblem());
        public static SequenceAnalysisProblem Instance => lazyInstance.Value;
        private static readonly string welcomeText = "This will find all uppercase letters within a given text and return them as an ordered list. Please provide input text.";
        private static readonly string problemName = "Sequence Analysis";
        public string WelcomeText() => welcomeText;
        public string ProblemName() => problemName;
        public (string RunResultText, bool IsRunSuccessful) Run(string Input)
        {
            var result = FilterAndOrderUppercase(Input);
            return ($"Ordered list of uppercase letters in your input string is: {result}", true);
        }
        private string FilterAndOrderUppercase(string input) => string.Concat(input.Where(l => char.IsUpper(l)).OrderBy(l => l));
    }
}
