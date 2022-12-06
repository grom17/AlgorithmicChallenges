using AlgorithmicChallenges.Problems.LeetCode.Easy.MinCostClimbingStairs;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class MinCostClimbingStairsTests
    {
        [TestCase(new[] { 10, 15, 20 }, ESolutionType.BottomUpDynamicProgramming, ExpectedResult = 15)]
        [TestCase(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, ESolutionType.BottomUpDynamicProgramming, ExpectedResult = 6)]
        [TestCase(new[] { 10, 15, 20 }, ESolutionType.TopDownDynamicProgramming, ExpectedResult = 15)]
        [TestCase(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, ESolutionType.TopDownDynamicProgramming, ExpectedResult = 6)]
        [TestCase(new[] { 10, 15, 20 }, ESolutionType.BottomUpConstantSpace, ExpectedResult = 15)]
        [TestCase(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, ESolutionType.BottomUpConstantSpace, ExpectedResult = 6)]
        public int Test(int[] costs, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(costs, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}