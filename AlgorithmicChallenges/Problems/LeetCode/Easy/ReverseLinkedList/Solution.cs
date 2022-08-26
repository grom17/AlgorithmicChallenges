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
                ESolutionType.Iterative => ReverseIteratively(head),
                ESolutionType.Recursive => ReverseRecursively(head),
                ESolutionType.Recursive2 => ReverseRecursively2(head),
                ESolutionType.Recursive3 => ReverseRecursively3(head),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static ListNode? ReverseIteratively(ListNode? head)
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

        private static ListNode? ReverseRecursively(ListNode? head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var newHead = ReverseRecursively(head.next);
            head.next.next = head;
            head.next = null;

            return newHead;
        }

        private static ListNode? ReverseRecursively2(ListNode? head, ListNode? newHead = null)
        {
            if (head == null)
            {
                return newHead;
            }

            var next = head.next;
            head.next = newHead;
            
            return ReverseRecursively2(next, head);
        }

        private static ListNode? ReverseRecursively3(ListNode? head)
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