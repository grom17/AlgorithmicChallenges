namespace AlgorithmicChallenges.Tests.Problems.HackerRank.InterviewPreparationKit.Array.LeftRotation
{
    using System.Linq;
    using AlgorithmicChallenges.Problems.HackerRank.InterviewPreparationKit.Array.LeftRotation;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class LeftRotationTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 4, ESolutionType.My, new[] { 5, 1, 2, 3, 4 })]
        [TestCase(new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10,
            ESolutionType.My,
            new[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        [TestCase(new[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13,
            ESolutionType.My,
            new[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 4, ESolutionType.Best, new[] { 5, 1, 2, 3, 4 })]
        [TestCase(new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10,
            ESolutionType.Best,
            new[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        [TestCase(new[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13,
            ESolutionType.Best,
            new[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        public void Test(int[] a, int d, ESolutionType solutionType, int[] expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(a.ToList(), d, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}