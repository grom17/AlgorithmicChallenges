using System;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.ValidPalindrome
{
    /// <summary>
    ///    Given a string s, return true if it is a palindrome, or false otherwise.
    ///    https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    public static class Solution
    {
        public static bool Run(string s, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.ReverseAndCompareStrings => ReverseAndCompareStrings(s),
                ESolutionType.Loops => Loops(s),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool ReverseAndCompareStrings(string s)
        {
            var onlyLettersAndDigits = new string(s
                .ToLowerInvariant()
                .Where(x => char.IsLetter(x) || char.IsDigit(x))
                .ToArray()
            );
            var reversedString = new string(onlyLettersAndDigits.Reverse().ToArray());

            return onlyLettersAndDigits.Equals(reversedString);
        }

        private static bool Loops(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }

            s = s.ToLowerInvariant();

            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                while (left < right && IsNonAlphaNumeric(s[left]))
                {
                    left++;
                }

                while (left < right && IsNonAlphaNumeric(s[right]))
                {
                    right--;
                }

                var isSame = s[left] == s[right];
                if (!isSame)
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        private static bool IsNonAlphaNumeric(char ch)
        {
            var isNonAlpha = ch is < 'a' or > 'z';
            var isNonNumeric = ch is < '0' or > '9';

            return isNonAlpha && isNonNumeric;
        }
    }
}