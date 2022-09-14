using System.Linq;
using AlgorithmicChallenges.Problems.LeetCode.Easy.InvertBinaryTree;
using AlgorithmicChallenges.Structures;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class InvertBinaryTreeTests
    {
        [TestCase(new[] { 4, 2, 7, 1, 3, 6, 9 }, ESolutionType.InvertRecursively, ExpectedResult = new[] { 4, 7, 2, 9, 6, 3, 1 })]
        [TestCase(new[] { 2, 1, 3 }, ESolutionType.InvertRecursively, ExpectedResult = new[] { 2, 3, 1 })]
        [TestCase(new int[0], ESolutionType.InvertRecursively, ExpectedResult = new int[0])]
        [TestCase(new[] { 4, 2, 7, 1, 3, 6, 9 }, ESolutionType.InvertUsingQueue, ExpectedResult = new[] { 4, 7, 2, 9, 6, 3, 1 })]
        [TestCase(new[] { 2, 1, 3 }, ESolutionType.InvertUsingQueue, ExpectedResult = new[] { 2, 3, 1 })]
        [TestCase(new int[0], ESolutionType.InvertUsingQueue, ExpectedResult = new int[0])]
        public int[] Test(int[] values, ESolutionType solutionType)
        {
            var root = new BinaryTree(values).Root;
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(root, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return BinaryTree.ConvertToLevelOrderedEnumeration(result).ToArray();
        }
    }
}