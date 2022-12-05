using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmicChallenges.Structures;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.NaryTreePreorderTraversal
{
    /// <summary>
    ///    Given the root of an n-ary tree, return the preorder traversal of its nodes' values.
    ///    Nary-Tree input serialization is represented in their level order traversal. Each group of children is separated by the null value
    ///    https://leetcode.com/problems/n-ary-tree-preorder-traversal
    /// </summary>
    public static class Solution
    {
        public static IList<int> Run(Node? root, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Recursion => Recursion(root),
                ESolutionType.Iteration => Iteration(root),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static IList<int> Recursion(Node? root)
        {
            var result = new List<int>();
            GetNodeValue(root, result);

            return result;
        }

        private static void GetNodeValue(Node? node, IList<int> result)
        {
            if (node == null)
            {
                return;
            }
            
            result.Add(node.val);

            foreach (var childNode in node.children)
            {
                GetNodeValue(childNode, result);
            }
        }

        private static IList<int> Iteration(Node? root)
        {
            var stack = new Stack<Node>();
            var output = new List<int>();
            
            if (root == null) 
            {
                return output;
            }

            stack.Push(root);
            while (stack.Any()) 
            {
                var node = stack.Pop();
                output.Add(node.val);
                for (var i = node.children.Count - 1; i >= 0; i--) 
                {
                    stack.Push(node.children[i]);
                }
            }
            return output;
        }
    }
}