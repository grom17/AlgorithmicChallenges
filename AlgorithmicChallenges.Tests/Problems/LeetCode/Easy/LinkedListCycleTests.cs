using AlgorithmicChallenges.Problems.LeetCode.Easy.LinkedListCycle;
using AlgorithmicChallenges.Structures;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class LinkedListCycleTests
    {
        [TestCase(new[] { 3, 2, 0, -4 }, 1, ESolutionType.HashSet, ExpectedResult = true)]
        [TestCase(new[] { 1, 2 }, 0, ESolutionType.HashSet, ExpectedResult = true)]
        [TestCase(new[] { 1 }, -1, ESolutionType.HashSet, ExpectedResult = false)]
        [TestCase(new[] { 3, 2, 0, -4 }, 1, ESolutionType.TwoPointers, ExpectedResult = true)]
        [TestCase(new[] { 1, 2 }, 0, ESolutionType.TwoPointers, ExpectedResult = true)]
        [TestCase(new[] { 1 }, -1, ESolutionType.TwoPointers, ExpectedResult = false)]
        public bool Test(int[] input, int pos, ESolutionType solutionType)
        {
            var linkedList = ListNode.ConvertToCycledLinkedList(input, pos);
            
            var (result, timeElapsed) = RunWithStopwatch(() => 
                Solution.Run(linkedList, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}