using AlgorithmicChallenges.Problems.LeetCode.Easy.SingleNumber;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;
    
    [TestFixture]
    public class SingleNumberTests
    {
        [TestCase(new[] { 4, 2, 1, 2, 1 }, ESolutionType.GroupBy, ExpectedResult = 4)]
        [TestCase(new[] { 1 }, ESolutionType.GroupBy, ExpectedResult = 1)]
        [TestCase(new[] { 2, 2, 1 }, ESolutionType.GroupBy, ExpectedResult = 1)]
        [TestCase(new[] { 4, 2, 1, 2, 1 }, ESolutionType.HashSet, ExpectedResult = 4)]
        [TestCase(new[] { 1 }, ESolutionType.HashSet, ExpectedResult = 1)]
        [TestCase(new[] { 2, 2, 1 }, ESolutionType.HashSet, ExpectedResult = 1)]
        [TestCase(new[] { 4, 2, 1, 2, 1 }, ESolutionType.Xor, ExpectedResult = 4)]
        [TestCase(new[] { 1 }, ESolutionType.Xor, ExpectedResult = 1)]
        [TestCase(new[] { 2, 2, 1 }, ESolutionType.Xor, ExpectedResult = 1)]
        public int Test(int[] nums, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(nums, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}