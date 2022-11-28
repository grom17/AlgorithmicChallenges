using System;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.LongestPalindrome
{
    /// <summary>
    ///    Given a string s which consists of lowercase or uppercase letters,
    ///    return the length of the longest palindrome that can be built with those letters.
    ///    Letters are case sensitive, for example, "Aa" is not considered a palindrome here.
    ///    https://leetcode.com/problems/longest-palindrome
    /// </summary>
    public static class Solution
    {
        public static int Run(string s, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.LongestPalindrome => LongestPalindrome(s),
                ESolutionType.Best => Best(s),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int LongestPalindrome(string s)
        {
            var groups = s.GroupBy(x => x).ToArray();

            var uniqueCenterFound = false;
            var result = 0;

            foreach (var group in groups)
            {
                if (group.Count() == 1 && !uniqueCenterFound)
                {
                    uniqueCenterFound = true;
                    result++;
                }
                else
                {
                    result += group.Count() / 2 * 2;
                }
            }

            if (!uniqueCenterFound && result < s.Length)
            {
                result++;
            }

            return result;
        }

        private static int Best(string s)
        {
            var count = new int[128];
            foreach (var ch in s)
            {
                count[ch]++;
            }

            var result = 0;

            foreach (var v in count)
            {
                result += v / 2 * 2;
                if (result % 2 == 0 && v % 2 == 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}