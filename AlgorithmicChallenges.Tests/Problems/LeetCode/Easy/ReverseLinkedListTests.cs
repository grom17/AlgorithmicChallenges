using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmicChallenges.Problems.LeetCode.Easy.ReverseLinkedList;
using AlgorithmicChallenges.Structures;
using FluentAssertions;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class ReverseLinkedListTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ESolutionType.Iterative, new[] { 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2 }, ESolutionType.Iterative, new[] { 2, 1 })]
        [TestCase(new int[0], ESolutionType.Iterative, new int[0])]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ESolutionType.Recursive, new[] { 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2 }, ESolutionType.Recursive, new[] { 2, 1 })]
        [TestCase(new int[0], ESolutionType.Recursive, new int[0])]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ESolutionType.Recursive2, new[] { 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2 }, ESolutionType.Recursive2, new[] { 2, 1 })]
        [TestCase(new int[0], ESolutionType.Recursive2, new int[0])]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ESolutionType.Recursive3, new[] { 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2 }, ESolutionType.Recursive3, new[] { 2, 1 })]
        [TestCase(new int[0], ESolutionType.Recursive3, new int[0])]
        public void Test(int[] input, ESolutionType solutionType, int[] expectedResult)
        {
            var linkedList = ListNode.ConvertToLinkedList(input);
            var (reversedLinkedList, timeElapsed) = RunWithStopwatch(() => Solution.Run(linkedList, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");

            var convertedResult = ListNode.ConvertToArray(reversedLinkedList);
            convertedResult.Should().Equal(expectedResult);
        }
    }
}