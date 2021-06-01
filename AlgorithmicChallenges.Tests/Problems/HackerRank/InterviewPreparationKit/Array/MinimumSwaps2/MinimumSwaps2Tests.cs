namespace AlgorithmicChallenges.Tests.Problems.HackerRank.InterviewPreparationKit.Array.MinimumSwaps2
{
    using AlgorithmicChallenges.Problems.HackerRank.InterviewPreparationKit.Array.MinimumSwaps2;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class MinimumSwaps2Tests
    {
        [TestCase(new[] { 7, 1, 3, 2, 4, 5, 6 }, ESolutionType.My, 5)]
        [TestCase(new[] { 1, 3, 5, 2, 4, 6, 7 }, ESolutionType.My, 3)]
        [TestCase(new[] { 2, 3, 4, 1, 5 }, ESolutionType.My, 3)]
        [TestCase(new[] { 7, 1, 3, 2, 4, 5, 6 }, ESolutionType.Best, 5)]
        [TestCase(new[] { 1, 3, 5, 2, 4, 6, 7 }, ESolutionType.Best, 3)]
        [TestCase(new[] { 2, 3, 4, 1, 5 }, ESolutionType.Best, 3)]
        public void Test(int[] arr, ESolutionType solutionType, int expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(arr, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}