using AlgorithmicChallenges.Problems.LeetCode.Easy.LinkedListCycle;
using AlgorithmicChallenges.Structures;
using NUnit.Framework;
using System.Linq;

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
            var linkedList = ConvertToCycledLinkedList(input, pos);
            
            var (result, timeElapsed) = RunWithStopwatch(() => 
                Solution.Run(linkedList, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
        
        private static ListNode? ConvertToCycledLinkedList(int[] input, int pos)
        {
            if (pos == -1)
            {
                return ListNode.ConvertToLinkedList(input);
            }

            if (input.Any())
            {
                var head = new ListNode();
                var current = head;
                ListNode? cycledNode = null;
                for (var index = 0; index < input.Length; index++)
                {
                    var value = input[index];
                    current!.val = value;

                    if (index == pos)
                    {
                        cycledNode = current;
                    }

                    if (index < input.Length - 1)
                    {
                        current.next = new ListNode();
                    }
                    else
                    {
                        current.next = cycledNode;
                        break;
                    }

                    current = current.next;
                }

                return head;
            }

            return null;
        }
    }
}