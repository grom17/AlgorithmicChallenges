namespace AlgorithmicChallenges.Tests.Problems.HackerRank.WarmupChallenges.JumpingOnTheClouds
{
    using System.Linq;
    using AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.JumpingOnTheClouds;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class JumpingOnTheCloudsTests
    {
        [TestCase(new[] { 0, 0, 1, 0, 0, 1, 0 }, ESolutionType.My, 4)]
        [TestCase(new[] { 0, 0, 0, 0, 1, 0 }, ESolutionType.My, 3)]
        [TestCase(new[] { 0, 0, 0, 1, 0, 0 }, ESolutionType.My, 3)]
        [TestCase(new[] { 0, 0, 1, 0, 0, 1, 0 }, ESolutionType.Best, 4)]
        [TestCase(new[] { 0, 0, 0, 0, 1, 0 }, ESolutionType.Best, 3)]
        [TestCase(new[] { 0, 0, 0, 1, 0, 0 }, ESolutionType.Best, 3)]
        public void Test(int[] c, ESolutionType solutionType, int expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(c.ToList(), solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}