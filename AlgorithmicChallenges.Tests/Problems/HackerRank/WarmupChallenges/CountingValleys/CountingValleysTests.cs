namespace AlgorithmicChallenges.Tests.Problems.HackerRank.WarmupChallenges.CountingValleys
{
    using AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.CountingValleys;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class CountingValleysTests
    {
        [TestCase(8, "UDDDUDUU", ESolutionType.My, 1)]
        [TestCase(12, "DDUUDDUDUUUD", ESolutionType.My, 2)]
        [TestCase(8, "UDDDUDUU", ESolutionType.Best, 1)]
        [TestCase(12, "DDUUDDUDUUUD", ESolutionType.Best, 2)]
        public void Test(int steps, string path, ESolutionType solutionType, int expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(steps, path, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}