using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.ValidParentheses
{
    /// <summary>
    ///    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
    ///    determine if the input string is valid.
    ///    An input string is valid if:
    ///     * Open brackets must be closed by the same type of brackets.
    ///     * Open brackets must be closed in the correct order.
    ///    https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public static class Solution
    {
        public static bool Run(string s, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Stack => Stack(s),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool Stack(string s)
        {
            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (!IsOpeningParenthesis(ch) && !stack.Any())
                {
                    return false;
                }
                
                if (IsOpeningParenthesis(ch))
                {
                    stack.Push(ch);
                    
                    continue;
                }

                if (stack.Peek() != GetOpeningParenthesis(ch))
                {
                    return false;
                }

                stack.Pop();
            }

            return !stack.Any();
        }

        private static bool IsOpeningParenthesis(char ch)
        {
            return ch is '(' or '[' or '{';
        }

        private static char GetOpeningParenthesis(char ch)
        {
            return ch switch
            {
                ')' => '(',
                ']' => '[',
                '}' => '{',
                _ => throw new ArgumentOutOfRangeException(nameof(ch), ch, null)
            };
        }
    }
}