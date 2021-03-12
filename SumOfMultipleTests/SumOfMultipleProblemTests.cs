using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfMultiple.Tests
{
    [TestClass()]
    public class SumOfMultipleProblemTests
    {
        [TestMethod()]
        public void RunTest_15()
        {
            int limit = 15;
            // 12, 10, 9, 6, 5, 3 => 45
            var problem = SumOfMultipleProblem.Instance;

            var (RunResultText, IsRunSuccessful) = problem.Run(limit.ToString());
            Assert.AreEqual($"Sum of 6 natural numbers which are either multiple of 3 or 5 and below 15 is 45.", RunResultText);
            Assert.IsTrue(IsRunSuccessful);
        }
        [TestMethod()]
        public void RunTest_1()
        {
            int limit = 1;
            var problem = SumOfMultipleProblem.Instance;

            var (RunResultText, IsRunSuccessful) = problem.Run(limit.ToString());
            Assert.AreEqual($"Sum of 0 natural numbers which are either multiple of 3 or 5 and below 1 is 0.", RunResultText);
            Assert.IsTrue(IsRunSuccessful);
        }
        [TestMethod()]
        public void RunTest_0()
        {
            int limit = 0;
            var problem = SumOfMultipleProblem.Instance;

            var (RunResultText, IsRunSuccessful) = problem.Run(limit.ToString());
            Assert.AreEqual($"Sum of 0 natural numbers which are either multiple of 3 or 5 and below 0 is 0.", RunResultText);
            Assert.IsTrue(IsRunSuccessful);
        }
        [TestMethod()]
        public void RunTest_NaN()
        {
            string input = "n";
            var problem = SumOfMultipleProblem.Instance;

            var (RunResultText, IsRunSuccessful) = problem.Run(input);
            Assert.AreEqual($"Input you provided is not a natural number. Please provide a natural number.", RunResultText);
            Assert.IsFalse(IsRunSuccessful);
        }
        [TestMethod()]
        public void RunTest_Overflow()
        {
            int limit = 100000;
            var problem = SumOfMultipleProblem.Instance;

            var (RunResultText, IsRunSuccessful) = problem.Run(limit.ToString());
            Assert.AreEqual($"The sum you requested is too large to calculate, please lower your limit.", RunResultText);
            Assert.IsFalse(IsRunSuccessful);
        }
    }
}