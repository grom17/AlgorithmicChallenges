using System;
using System.Collections.Generic;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.IsSubsequence
{
    /// <summary>
    ///    Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    ///    A subsequence of a string is a new string that is formed from the original string by deleting some (can be none)
    ///    of the characters without disturbing the relative positions of the remaining characters.
    ///    (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    ///    https://leetcode.com/problems/is-subsequence
    /// </summary>
    public static class Solution
    {
        public static bool Run(string s, string t, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.IsSubsequence => IsSubsequence(s, t),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool IsSubsequence(string s, string t)
        {
            var indexS = 0;
            var indexT = 0;
            while (indexS < s.Length && indexT < t.Length)
            {
                if (s[indexS] == t[indexT])
                {
                    indexS++;
                }
                
                indexT++;
            }

            return indexS == s.Length;
        }
    }
}