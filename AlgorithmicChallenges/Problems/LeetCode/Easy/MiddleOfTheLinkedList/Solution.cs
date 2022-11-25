using System;
using System.Collections.Generic;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.MiddleOfTheLinkedList
{
    /// <summary>
    ///    Given the head of a singly linked list, return the middle node of the linked list.
    ///    If there are two middle nodes, return the second middle node.
    ///    https://leetcode.com/problems/middle-of-the-linked-list
    /// </summary>
    public static class Solution
    {
        public static ListNode Run(ListNode head, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Dictionary => Dictionary(head),
                ESolutionType.TwoPointers => TwoPointers(head),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static ListNode Dictionary(ListNode head)
        {
            var currentNode = head;
            var nodes = new Dictionary<int, ListNode>();

            var index = 0;
            while (currentNode != null)
            {
                nodes.Add(index, currentNode);
                currentNode = currentNode.next;
                index++;
            }

            var middleNodeIndex = nodes.Count / 2;
            
            return nodes[middleNodeIndex];
        }
        
        private static ListNode TwoPointers(ListNode head)
        {
            var middleNode = head;
            var endNode = head;

            while (endNode?.next != null)
            {
                middleNode = middleNode!.next;
                endNode = endNode.next.next;
            }

            return middleNode!;
        }
    }
}