using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SequenceAnalysis.Tests
{
    [TestClass()]
    public class SequenceAnalysisProblemTests
    {
        [TestMethod()]
        public void RunTests()
        {
            string inputText = "This IS a STRING";
            var problem = SequenceAnalysisProblem.Instance;

            var result = problem.Run(inputText);

            Assert.AreEqual($"Ordered list of uppercase letters in your input string is: GIINRSSTT", result.RunResultText);
            Assert.IsTrue(result.IsRunSuccessful);
        }
    }
}