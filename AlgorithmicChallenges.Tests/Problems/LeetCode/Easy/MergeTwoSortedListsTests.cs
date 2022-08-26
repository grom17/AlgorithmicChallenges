using AlgorithmicChallenges.Problems.LeetCode.Easy.MergeTwoSortedLists;
using AlgorithmicChallenges.Structures;
using FluentAssertions;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class MergeTwoSortedListsTests
    {
        [TestCase(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, ESolutionType.MergeIteratively, new[] { 1, 1, 2, 3, 4, 4 })]
        [TestCase(new int[0], new int[0], ESolutionType.MergeIteratively, new int[0])]
        [TestCase(new int[0], new[] { 0 }, ESolutionType.MergeIteratively, new[] { 0 })]
        [TestCase(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, ESolutionType.MergeRecursively, new[] { 1, 1, 2, 3, 4, 4 })]
        [TestCase(new int[0], new int[0], ESolutionType.MergeRecursively, new int[0])]
        [TestCase(new int[0], new[] { 0 }, ESolutionType.MergeRecursively, new[] { 0 })]
        [TestCase(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, ESolutionType.MergeRecursively2, new[] { 1, 1, 2, 3, 4, 4 })]
        [TestCase(new int[0], new int[0], ESolutionType.MergeRecursively2, new int[0])]
        [TestCase(new int[0], new[] { 0 }, ESolutionType.MergeRecursively2, new[] { 0 })]
        public void Test(int[] input1, int[] input2, ESolutionType solutionType, int[] expectedResult)
        {
            var linkedList1 = ListNode.ConvertToLinkedList(input1);
            var linkedList2 = ListNode.ConvertToLinkedList(input2);
            
            var (reversedLinkedList, timeElapsed) = RunWithStopwatch(() => 
                Solution.Run(linkedList1, linkedList2, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");

            var convertedResult = ListNode.ConvertToArray(reversedLinkedList);
            convertedResult.Should().Equal(expectedResult);
        }
    }
}