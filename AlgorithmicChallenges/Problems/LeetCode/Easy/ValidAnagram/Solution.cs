using System;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.ValidAnagram
{
    /// <summary>
    ///    Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    ///    An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
    ///    typically using all the original letters exactly once.
    ///    https://leetcode.com/problems/valid-anagram/
    /// </summary>
    public static class Solution
    {
        public static bool Run(string s, string t, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.SortCharsAndCompareStrings => SortCharsAndCompareStrings(s, t),
                ESolutionType.SortCharsAndCompareSequences => SortCharsAndCompareSequences(s, t),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool SortCharsAndCompareStrings(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var firstStringCharArray = s.ToCharArray();
            var secondStringCharArray = t.ToCharArray();
            Array.Sort(firstStringCharArray);
            Array.Sort(secondStringCharArray);
            var sortedFirstString = new string(firstStringCharArray);
            var sortedSecondString = new string(secondStringCharArray);
            
            return sortedFirstString.Equals(sortedSecondString);
        }
        
        private static bool SortCharsAndCompareSequences(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var firstStringCharArray = s.ToCharArray();
            var secondStringCharArray = t.ToCharArray();
            Array.Sort(firstStringCharArray);
            Array.Sort(secondStringCharArray);
            
            return firstStringCharArray.SequenceEqual(secondStringCharArray);
        }
    }
}