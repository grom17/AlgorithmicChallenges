using AlgorithmicChallenges.Problems.LeetCode.Easy.RangeSumOfBST;
using AlgorithmicChallenges.Structures;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class RangeSumOfBstTests
    {
        [TestCase(new object?[] { 10, 5, 15, 3, 7, null, 18 }, 7, 15, ESolutionType.Recursion, ExpectedResult = 32)]
        [TestCase(new object?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 }, 6, 10, ESolutionType.Recursion,
            ExpectedResult = 23)]
        [TestCase(new object?[] { 10, 5, 15, 3, 7, null, 18 }, 7, 15, ESolutionType.Iteration, ExpectedResult = 32)]
        [TestCase(new object?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 }, 6, 10, ESolutionType.Iteration,
            ExpectedResult = 23)]
        public int Test(object?[] values, int low, int high, ESolutionType solutionType)
        {
            var root = new BinaryTree(values).Root;
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(root, low, high, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}