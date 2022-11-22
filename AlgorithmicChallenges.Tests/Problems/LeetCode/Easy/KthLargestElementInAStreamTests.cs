using System.Linq;
using AlgorithmicChallenges.Problems.LeetCode.Easy.KthLargestElementInAStream;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class KthLargestElementInAStreamTests
    {
        [TestCase(3, new[] { 4, 5, 8, 2 }, new[] { 3, 5, 10, 9, 4 }, ESolutionType.KthLargest, ExpectedResult = new[] { 4, 5, 5, 8, 8 })]
        public int[] Test(int k, int[] nums, int[] values, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(k, nums, values, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");

            return result.ToArray();
        }
    }
}