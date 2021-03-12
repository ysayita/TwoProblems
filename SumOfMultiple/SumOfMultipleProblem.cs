using ProblemBase;
using System;
using System.Linq;

namespace SumOfMultiple
{
    public class SumOfMultipleProblem : IProblem
    {
        private SumOfMultipleProblem() { }
        private static readonly Lazy<SumOfMultipleProblem> lazyInstance = new Lazy<SumOfMultipleProblem>(() => new SumOfMultipleProblem());
        public static SumOfMultipleProblem Instance => lazyInstance.Value;
        private static readonly string welcomeText = "This will calculate the sum of all natural numbers that are multiple of 3 or 5 below the given limit. Please provide a limit.";
        private static readonly string problemName = "Sum of Multiple";
        public string WelcomeText() => welcomeText;
        public string ProblemName() => problemName;
        public (string RunResultText, bool IsRunSuccessful) Run(string Input)
        {
            if (!int.TryParse(Input, out var Limit))
            {
                return ("Input you provided is not a natural number. Please provide a natural number.", false);
            }
            var numbers = Enumerable.Range(0, Limit).Where(n => n.IsMultiple(3) || n.IsMultiple(5));
            try
            {
                return ($"Sum of {numbers.Count():N0} natural numbers which are either multiple of 3 or 5 and below {Limit:N0} is {numbers.Sum():N0}.", true);
            }
            catch (OverflowException)
            {
                return ("The sum you requested is too large to calculate, please lower your limit.", false);
            }
            catch (Exception)
            {
                return ("Could not calculate, please try again.", false);
            }
        }
    }
}
