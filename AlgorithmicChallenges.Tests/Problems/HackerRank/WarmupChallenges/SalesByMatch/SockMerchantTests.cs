namespace AlgorithmicChallenges.Tests.Problems.HackerRank.WarmupChallenges.SalesByMatch
{
    using System.Linq;
    using AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.SalesByMatch;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class SockMerchantTests
    {
        [TestCase(7, new[] { 1, 2, 1, 2, 1, 3, 2 }, ESolutionType.GroupBy, 2)]
        [TestCase(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ESolutionType.GroupBy, 3)]
        [TestCase(10, new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 }, ESolutionType.GroupBy, 4)]
        [TestCase(7, new[] { 1, 2, 1, 2, 1, 3, 2 }, ESolutionType.Loops, 2)]
        [TestCase(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ESolutionType.Loops, 3)]
        [TestCase(10, new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 }, ESolutionType.Loops, 4)]
        [TestCase(7, new[] { 1, 2, 1, 2, 1, 3, 2 }, ESolutionType.HashSet, 2)]
        [TestCase(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ESolutionType.HashSet, 3)]
        [TestCase(10, new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 }, ESolutionType.HashSet, 4)]
        [TestCase(7, new[] { 1, 2, 1, 2, 1, 3, 2 }, ESolutionType.Lookup, 2)]
        [TestCase(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, ESolutionType.Lookup, 3)]
        [TestCase(10, new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 }, ESolutionType.Lookup, 4)]
        public void Test(int n, int[] ar, ESolutionType solutionType, int expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n, ar.ToList(), solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}