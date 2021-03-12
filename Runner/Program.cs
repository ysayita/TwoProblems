using ProblemBase;
using SequenceAnalysis;
using SumOfMultiple;
using System;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            bool exit;
            do
            {
                IProblem selectedProblem = null;
                do
                {
                    Console.WriteLine(@$"Please choose a problem to solve:
1) {SumOfMultipleProblem.Instance.ProblemName()}
2) {SequenceAnalysisProblem.Instance.ProblemName()}");
                    var problemSelection = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (problemSelection.Equals('1'))
                    {
                        selectedProblem = SumOfMultipleProblem.Instance;
                    }
                    else if (problemSelection.Equals('2'))
                    {
                        selectedProblem = SequenceAnalysisProblem.Instance;
                    }
                    else
                    {
                        Console.WriteLine("Please provide a choice among listed problems, 1 or 2.");
                    }
                } while (selectedProblem == null);
                bool runSuccessful;
                do
                {
                    Console.WriteLine(selectedProblem.WelcomeText());
                    var (RunResultText, IsRunSuccessful) = selectedProblem.Run(Console.ReadLine().Trim());
                    Console.WriteLine(RunResultText);
                    runSuccessful = IsRunSuccessful;
                } while (!runSuccessful);
                Console.WriteLine("Press e to exit, anything else to re-run.");
                var exitResponse = Console.ReadKey();
                exit = exitResponse.KeyChar.Equals('e');
                Console.Clear();
            } while (!exit);
        }
    }
}
