using System;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.ReverseLinkedList
{
    /// <summary>
    ///    Given the head of a singly linked list, reverse the list, and return the reversed list.
    ///    https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public static class Solution
    {
        public static ListNode? Run(ListNode? head, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Iterative => ReverseIterative(head),
                ESolutionType.Recursive => ReverseRecursive(head),
                ESolutionType.Recursive2 => ReverseRecursive2(head),
                ESolutionType.Recursive3 => ReverseRecursive3(head),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static ListNode? ReverseIterative(ListNode? head)
        {
            ListNode? previous = null;

            while (head != null)
            {
                var next = head.next;
                head.next = previous;
                previous = head;
                head = next;
            }

            return previous;
        }

        private static ListNode? ReverseRecursive(ListNode? head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var newHead = ReverseRecursive(head.next);
            head.next.next = head;
            head.next = null;

            return newHead;
        }

        private static ListNode? ReverseRecursive2(ListNode? head, ListNode? newHead = null)
        {
            if (head == null)
            {
                return newHead;
            }

            var next = head.next;
            head.next = newHead;
            
            return ReverseRecursive2(next, head);
        }

        private static ListNode? ReverseRecursive3(ListNode? head)
        {
            return head?.next != null 
                ? HelperReverse(null, head, head.next) 
                : head;
        }

        private static ListNode? HelperReverse(ListNode? previous, ListNode current, ListNode? next)
        {
            current.next = previous;
            
            return next != null 
                ? HelperReverse(current, next, next.next) 
                : current;
        }
    }
}