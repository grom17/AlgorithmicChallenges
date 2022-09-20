using System;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.PlusOne
{
    /// <summary>
    ///    You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
    ///    The digits are ordered from most significant to least significant in left-to-right order.
    ///    The large integer does not contain any leading 0's.
    ///    Increment the large integer by one and return the resulting array of digits.
    ///    https://leetcode.com/problems/plus-one/
    /// </summary>
    public static class Solution
    {
        public static int[] Run(int[] digits, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.PlusOne => PlusOne(digits),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int[] PlusOne(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                    
                    return digits;
                }

                digits[i] = 0;
            }

            return new[] { 1 }.Concat(digits).ToArray();
        }
    }
}