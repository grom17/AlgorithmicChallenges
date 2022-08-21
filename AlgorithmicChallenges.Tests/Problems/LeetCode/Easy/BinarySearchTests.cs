using AlgorithmicChallenges.Problems.LeetCode.Easy.BinarySearch;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class BinarySearchTests
    {
        [TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 9, ESolutionType.BinarySearch, ExpectedResult = 4)]
        [TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 2, ESolutionType.BinarySearch, ExpectedResult = -1)]
        [TestCase(new[] { 1 }, 1, ESolutionType.BinarySearch, ExpectedResult = 0)]
        [TestCase(new[] { 1 }, 0, ESolutionType.BinarySearch, ExpectedResult = -1)]
        [TestCase(new[] { 2, 5 }, 5, ESolutionType.BinarySearch, ExpectedResult = 1)]
        [TestCase(new[] { 2, 5 }, 0, ESolutionType.BinarySearch, ExpectedResult = -1)]
        [TestCase(new[] { -1, 0, 5 }, 5, ESolutionType.BinarySearch, ExpectedResult = 2)]
        public int Test(int[] nums, int target, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(nums, target, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}