using System.Linq;
using AlgorithmicChallenges.Problems.LeetCode.Easy.MiddleOfTheLinkedList;
using AlgorithmicChallenges.Structures;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class MiddleOfTheLinkedListTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ESolutionType.Dictionary,  ExpectedResult = new[] { 3, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, ESolutionType.Dictionary,  ExpectedResult = new[] { 4, 5, 6 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ESolutionType.TwoPointers,  ExpectedResult = new[] { 3, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, ESolutionType.TwoPointers,  ExpectedResult = new[] { 4, 5, 6 })]
        public int[] Test(int[] input, ESolutionType solutionType)
        {
            var linkedList = ListNode.ConvertToLinkedList(input);
            
            var (middleNode, timeElapsed) = RunWithStopwatch(() => Solution.Run(linkedList!, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");

            return ListNode.ConvertToArray(middleNode).ToArray();
        }
    }
}