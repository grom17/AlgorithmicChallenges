using System;
using System.Collections.Generic;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.HappyNumber
{
    /// <summary>
    ///    Write an algorithm to determine if a number n is happy.
    ///    A happy number is a number defined by the following process:
    ///    Starting with any positive integer, replace the number by the sum of the squares of its digits.
    ///    Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    ///    Those numbers for which this process ends in 1 are happy.
    ///    Return true if n is a happy number, and false if not.
    ///    https://leetcode.com/problems/happy-number/
    /// </summary>
    public static class Solution
    {
        public static bool Run(int n, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.HashSet => HashSet(n),
                ESolutionType.TwoPointers => TwoPointers(n),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool HashSet(int n)
        {
            var results = new HashSet<int>();
            while (n != 1 && !results.Contains(n))
            {
                results.Add(n);
                n = GetNextResult(n);
            }

            return n == 1;
        }

        private static bool TwoPointers(int n)
        {
            var slow = n;
            var fast = GetNextResult(n);
            while (fast != 1 && slow != fast)
            {
                slow = GetNextResult(slow);
                fast = GetNextResult(GetNextResult(fast));
            }

            return fast == 1;
        }

        private static int GetNextResult(int n)
        {
            var result = 0;
            while (n != 0)
            {
                var digit = n % 10;
                result += digit * digit;
                n /= 10;
            }

            return result;
        }
    }
}