using System;
using System.Collections.Generic;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.RangeSumOfBST
{
    /// <summary>
    ///    Given the root node of a binary search tree and two integers low and high,
    ///    return the sum of values of all nodes with a value in the inclusive range [low, high].
    ///    https://leetcode.com/problems/range-sum-of-bst/
    /// </summary>
    public static class Solution
    {
        public static int Run(TreeNode? root, int low, int high, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Recursion => Recursion(root, low, high),
                ESolutionType.Iteration => Iteration(root, low, high),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int Recursion(TreeNode? root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.Value > high)
            {
                return Recursion(root.Left, low, high);
            }

            if (root.Value < low)
            {
                return Recursion(root.Right, low, high);
            }
            return root.Value + Recursion(root.Left, low, high) + Recursion(root.Right, low, high);
        }

        private static int Iteration(TreeNode? root, int low, int high)
        {
            var sum = 0;
            var stack = new Stack<TreeNode?>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }

                if (low <= node.Value && node.Value <= high)
                {
                    sum += node.Value;
                }

                if (low < node.Value)
                {
                    stack.Push(node.Left);
                }

                if (node.Value < high)
                {
                    stack.Push(node.Right);
                }
            }

            return sum;
        }
    }
}