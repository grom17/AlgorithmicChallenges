using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.InvertBinaryTree
{
    /// <summary>
    ///    Given the root of a binary tree, invert the tree, and return its root.
    ///    https://leetcode.com/problems/invert-binary-tree/
    /// </summary>
    public static class Solution
    {
        public static TreeNode? Run(TreeNode? root, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.InvertRecursively => InvertRecursively(root),
                ESolutionType.InvertUsingQueue => InvertUsingQueue(root),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static TreeNode? InvertRecursively(TreeNode? root)
        {
            if (root != null)
            {
                var left = root.Left;
                root.Left = InvertRecursively(root.Right);
                root.Right = InvertRecursively(left);
            }
                
            return root;
        }
        
        private static TreeNode? InvertUsingQueue(TreeNode? root)
        {
            if (root != null)
            {
                var queue = new Queue<TreeNode?>();
                queue.Enqueue(root);
                
                while (queue.Any())
                {
                    var node = queue.Dequeue();

                    if (node == null)
                    {
                        continue;
                    }
                
                    (node.Left, node.Right) = (node.Right, node.Left);

                    queue.Enqueue(node.Left);
                    queue.Enqueue(node.Right);
                }
            }

            return root;
        }
    }
}