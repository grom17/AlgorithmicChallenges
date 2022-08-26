using System;
using System.Collections.Generic;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.LinkedListCycle
{
    /// <summary>
    ///    Given head, the head of a linked list, determine if the linked list has a cycle in it.
    ///    There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
    ///    Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
    ///    Return true if there is a cycle in the linked list. Otherwise, return false.
    ///    https://leetcode.com/problems/linked-list-cycle/
    /// </summary>
    public static class Solution
    {
        public static bool Run(ListNode? head, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.HashSet => HasCycle(head),
                ESolutionType.TwoPointers => TwoPointers(head),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool HasCycle(ListNode? head)
        {
            var nodes = new HashSet<ListNode>();

            var current = head;
            while (current != null)
            {
                if (nodes.Contains(current))
                {
                    return true;
                }

                nodes.Add(current);

                current = current.next;
            }

            return false;
        }
        
        private static bool TwoPointers(ListNode? head)
        {
            var slow = head;
            var fast = head;

            while (fast is { next: { } })
            {
                slow = slow!.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}