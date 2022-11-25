using System;
using System.Collections.Generic;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Medium.LinkedListCycle2
{
    /// <summary>
    ///    Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.
    ///    There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
    ///    Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed).
    ///    It is -1 if there is no cycle. Note that pos is not passed as a parameter.
    ///    Do not modify the linked list.
    ///    https://leetcode.com/problems/linked-list-cycle-ii
    /// </summary>
    public static class Solution
    {
        public static ListNode? Run(ListNode? head, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.HashSet => HashSet(head),
                ESolutionType.TwoPointers => TwoPointers(head),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static ListNode? HashSet(ListNode? head)
        {
            var nodes = new HashSet<ListNode>();

            var current = head;
            while (current != null)
            {
                if (nodes.Contains(current))
                {
                    return current;
                }

                nodes.Add(current);

                current = current.next;
            }

            return null;
        }
        
        private static ListNode? TwoPointers(ListNode? head)
        {
            if (head == null) 
            {
                return null;
            }
            
            var intersect = GetIntersect(head);
            if (intersect == null) 
            {
                return null;
            }

            // To find the entrance to the cycle, we have two pointers traverse at
            // the same speed -- one from the front of the list, and the other from
            // the point of intersection.
            var ptr1 = head;
            var ptr2 = intersect;
            while (ptr1 != ptr2) 
            {
                ptr1 = ptr1!.next;
                ptr2 = ptr2!.next;
            }

            return ptr1;
        }
        
        private static ListNode? GetIntersect(ListNode? head) {
            var slow = head;
            var fast = head;

            while (fast is { next: { } })
            {
                slow = slow!.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return slow;
                }
            }

            return null;
        }

    }
}