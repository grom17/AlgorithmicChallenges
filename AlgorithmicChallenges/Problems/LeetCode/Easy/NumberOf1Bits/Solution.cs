using System;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.NumberOf1Bits
{
    /// <summary>
    ///    Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
    ///    https://leetcode.com/problems/number-of-1-bits/
    /// </summary>
    public static class Solution
    {
        public static int Run(uint n, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Sparse => Sparse(n),
                ESolutionType.Iterated => Iterated(n),
                ESolutionType.Iterated2 => Iterated2(n),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int Sparse(uint n)
        {
            var count = 0;
            while (n != 0)
            {
                count++;
                n &= n - 1;
            }
            return count;
        }

        private static int Iterated(uint n)
        {
            var test = n;
            var count = 0;
        
            while (test != 0)
            {
                if ((test & 1) == 1)
                {
                    count++;
                }
                test >>= 1;
            }
            return count;
        }
        
        private static int Iterated2(uint n)
        {
            var test = n;
            var count = 0;
        
            while (test != 0)
            {
                count += (int)(test % 2);
                test /= 2;
            }
            return count;
        }
    }
}