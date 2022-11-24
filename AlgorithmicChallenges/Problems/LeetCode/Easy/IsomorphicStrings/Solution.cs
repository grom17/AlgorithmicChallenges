using System;
using System.Collections.Generic;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.IsomorphicStrings
{
    /// <summary>
    ///    Given two strings s and t, determine if they are isomorphic.
    ///    Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    ///    All occurrences of a character must be replaced with another character while preserving the order of characters.
    ///    No two characters may map to the same character, but a character may map to itself.
    ///    https://leetcode.com/problems/isomorphic-strings
    /// </summary>
    public static class Solution
    {
        public static bool Run(string s, string t, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.IsIsomorphic => IsIsomorphic(s, t),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool IsIsomorphic(string s, string t)
        {
            var map = new Dictionary<char, char>();

            for (var index = 0; index < s.Length; index++)
            {
                var chS = s[index];
                var chT = t[index];
                if (!map.ContainsKey(chS))
                {
                    if (map.ContainsValue(chT))
                    {
                        return false;
                    }

                    map.Add(chS, chT);
                }
                else if (chT != map[chS])
                {
                    return false;
                }
            }

            return true;
        }
    }
}