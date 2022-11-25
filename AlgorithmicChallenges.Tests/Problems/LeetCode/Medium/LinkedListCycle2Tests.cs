using AlgorithmicChallenges.Problems.LeetCode.Medium.LinkedListCycle2;
using AlgorithmicChallenges.Structures;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Medium
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class LinkedListCycle2Tests
    {
        [TestCase(new[] { 3, 2, 0, -4 }, 1, ESolutionType.HashSet, ExpectedResult = 2)]
        [TestCase(new[] { 1, 2 }, 0, ESolutionType.HashSet, ExpectedResult = 1)]
        [TestCase(new[] { 1 }, -1, ESolutionType.HashSet, ExpectedResult = null)]
        [TestCase(new[] { 3, 2, 0, -4 }, 1, ESolutionType.TwoPointers, ExpectedResult = 2)]
        [TestCase(new[] { 1, 2 }, 0, ESolutionType.TwoPointers, ExpectedResult = 1)]
        [TestCase(new[] { 1 }, -1, ESolutionType.TwoPointers, ExpectedResult = null)]
        public int? Test(int[] input, int pos, ESolutionType solutionType)
        {
            var linkedList = ListNode.ConvertToCycledLinkedList(input, pos);
            
            var (result, timeElapsed) = RunWithStopwatch(() => 
                Solution.Run(linkedList, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result?.val;
        }
    }
}