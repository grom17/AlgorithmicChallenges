using System;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.MergeTwoSortedLists
{
    /// <summary>
    ///    You are given the heads of two sorted linked lists list1 and list2.
    ///    Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
    ///    Return the head of the merged linked list.
    ///    https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public static class Solution
    {
        public static ListNode? Run(ListNode? list1, ListNode? list2, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.MergeIteratively => MergeIteratively(list1, list2),
                ESolutionType.MergeRecursively => MergeRecursively(list1, list2),
                ESolutionType.MergeRecursively2 => MergeRecursively2(list1, list2),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static ListNode? MergeIteratively(ListNode? list1, ListNode? list2)
        {
            var root = new ListNode();
            var previous = root;
            
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    previous.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    previous.next = list2;
                    list2 = list2.next;
                }

                previous = previous.next;
            }

            previous.next = list1 ?? list2;
            
            return root.next;
        }

        private static ListNode? MergeRecursively(ListNode? list1, ListNode? list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            ListNode head;
            if (list1.val > list2.val)
            {
                head = list2;
                list2 = list2.next;
            }
            else
            {
                head = list1;
                list1 = list1.next;
            }

            head.next = MergeRecursively(list1, list2);

            return head;
        }
        
        private static ListNode? MergeRecursively2(ListNode? list1, ListNode? list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }
            
            if (list1.val < list2.val)
            {
                list1.next = MergeRecursively2(list1.next, list2);
                return list1;
            }

            list2.next = MergeRecursively2(list1, list2.next);
            return list2;
        }
    }
}