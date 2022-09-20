using AlgorithmicChallenges.Problems.LeetCode.Easy.LastStoneWeight;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class LastStoneWeightTests
    {
        [TestCase(new[] { 2, 7, 4, 1, 8, 1 }, ESolutionType.PriorityQueue, ExpectedResult = 1)]
        [TestCase(new[] { 9, 3, 2, 10 }, ESolutionType.PriorityQueue, ExpectedResult = 0)]
        [TestCase(new[] { 7, 6, 7, 6, 9 }, ESolutionType.PriorityQueue, ExpectedResult = 3)]
        [TestCase(new[] { 1 }, ESolutionType.PriorityQueue, ExpectedResult = 1)]
        [TestCase(new[] { 2, 7, 4, 1, 8, 1 }, ESolutionType.Foreach, ExpectedResult = 1)]
        [TestCase(new[] { 9, 3, 2, 10 }, ESolutionType.Foreach, ExpectedResult = 0)]
        [TestCase(new[] { 7, 6, 7, 6, 9 }, ESolutionType.Foreach, ExpectedResult = 3)]
        [TestCase(new[] { 1 }, ESolutionType.Foreach, ExpectedResult = 1)]
        public int Test(int[] stones, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(stones, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}