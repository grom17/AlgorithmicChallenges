using AlgorithmicChallenges.Problems.LeetCode.Easy.FindPivotIndex;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class FindPivotIndexTests
    {
        [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, ESolutionType.FindPivotIndex, ExpectedResult = 3)]
        [TestCase(new[] { 1, 2, 3 }, ESolutionType.FindPivotIndex, ExpectedResult = -1)]
        [TestCase(new[] { 2, 1, -1 }, ESolutionType.FindPivotIndex, ExpectedResult = 0)]
        [TestCase(new[] { -1, -1, -1, -1, 0, 0 }, ESolutionType.FindPivotIndex, ExpectedResult = -1)]
        [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, ESolutionType.Best, ExpectedResult = 3)]
        [TestCase(new[] { 1, 2, 3 }, ESolutionType.Best, ExpectedResult = -1)]
        [TestCase(new[] { 2, 1, -1 }, ESolutionType.Best, ExpectedResult = 0)]
        [TestCase(new[] { -1, -1, -1, -1, 0, 0 }, ESolutionType.Best, ExpectedResult = -1)]
        public int Test(int[] nums, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(nums, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}