using System.Collections.Generic;
using AlgorithmicChallenges.Problems.LeetCode.Easy.NaryTreePreorderTraversal;
using AlgorithmicChallenges.Structures;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class NaryTreePreorderTraversalTests
    {
        [TestCase(new object?[] { null }, ESolutionType.Recursion, ExpectedResult = new int[0])]
        [TestCase(new object?[0], ESolutionType.Recursion, ExpectedResult = new int[0])]
        [TestCase(new object?[] { 1, null, 3, 2, 4, null, 5, 6 }, ESolutionType.Recursion, ExpectedResult = new[] { 1, 3, 5, 6, 2, 4 })]
        [TestCase(
            new object?[]
            {
                1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14
            }, ESolutionType.Recursion, ExpectedResult = new[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 })]
        [TestCase(new object?[] { null }, ESolutionType.Iteration, ExpectedResult = new int[0])]
        [TestCase(new object?[0], ESolutionType.Iteration, ExpectedResult = new int[0])]
        [TestCase(new object?[] { 1, null, 3, 2, 4, null, 5, 6 }, ESolutionType.Iteration, ExpectedResult = new[] { 1, 3, 5, 6, 2, 4 })]
        [TestCase(
            new object?[]
            {
                1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14
            }, ESolutionType.Iteration, ExpectedResult = new[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 })]
        public IList<int> Test(object?[] values, ESolutionType solutionType)
        {
            var root = new NaryTree(values).Root;
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(root, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}