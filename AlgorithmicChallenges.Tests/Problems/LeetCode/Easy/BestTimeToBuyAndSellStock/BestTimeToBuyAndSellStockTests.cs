namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy.BestTimeToBuyAndSellStock
{
    using System;
    using System.IO;
    using System.Linq;
    using AlgorithmicChallenges.Problems.LeetCode.Easy.BestTimeToBuyAndSellStock;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class BestTimeToBuyAndSellStockTests
    {
        [TestCase("Simple", ESolutionType.BruteForce, ExpectedResult = 5, TestName = "BruteForce_Simple")]
        [TestCase("NoTransactions", ESolutionType.BruteForce, ExpectedResult = 0,
            TestName = "BruteForce_NoTransactions")]
        [TestCase("BigInput", ESolutionType.BruteForce, ExpectedResult = 999, TestName = "BruteForce_BigInput")]
        [TestCase("Simple", ESolutionType.MinPrice, ExpectedResult = 5,
            TestName = "MinPrice_Simple")]
        [TestCase("NoTransactions", ESolutionType.MinPrice, ExpectedResult = 0,
            TestName = "MinPrice_NoTransactions")]
        [TestCase("BigInput", ESolutionType.MinPrice, ExpectedResult = 999,
            TestName = "MinPrice_BigInput")]
        [TestCase("Simple", ESolutionType.OnePass, ExpectedResult = 5,
            TestName = "OnePass_Simple")]
        [TestCase("NoTransactions", ESolutionType.OnePass, ExpectedResult = 0,
            TestName = "OnePass_NoTransactions")]
        [TestCase("BigInput", ESolutionType.OnePass, ExpectedResult = 999,
            TestName = "OnePass_BigInput")]
        public int Test(string testCase, ESolutionType solutionType)
        {
            // Arrange
            var prices = GetPrices(testCase);

            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(prices, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }

        private static int[] GetPrices(string testCase)
        {
            var file = Path.Combine(@"Problems\LeetCode\Easy\BestTimeToBuyAndSellStock\TestCases", $"{testCase}.txt");

            return File.Exists(file)
                ? File.ReadAllText(file).Split(',').Select(int.Parse).ToArray()
                : Array.Empty<int>();
        }
    }
}