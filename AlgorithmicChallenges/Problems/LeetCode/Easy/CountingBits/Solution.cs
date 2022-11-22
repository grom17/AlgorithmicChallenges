using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.CountingBits
{
    /// <summary>
    ///    Given an integer n, return an array ans of length n + 1
    ///    such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
    ///    https://leetcode.com/problems/number-of-1-bits/
    /// </summary>
    [SuppressMessage("ReSharper", "InvalidXmlDocComment")]
    public static class Solution
    {
        public static int[] Run(int n, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.CountBitsIterated => CountBitsIterated(n),
                ESolutionType.CountBitsDpWithOffset => CountBitsDpWithOffset(n),
                ESolutionType.CountBitsDp => CountBitsDp(n),
                ESolutionType.CountBitsDp2 => CountBitsDp2(n),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }
        
        private static int[] CountBitsIterated(int n)
        {
            var result = new List<int>();
            
            for (var i = 0; i <= n; i++)
            {
                var test = i;
                var count = 0;
        
                while (test != 0)
                {
                    count += test % 2;
                    test /= 2;
                }
                result.Add(count);
            }
            
            return result.ToArray();
        }
        
        private static int[] CountBitsDpWithOffset(int n)
        {
            var dp = new int[n + 1];
            var offset = 1;
            
            for (var i = 1; i <= n; i++) 
            {
                if (offset * 2 == i)
                {
                    offset = i;
                }

                dp[i] = 1 + dp[i - offset];
            }

            return dp;
        }

        private static int[] CountBitsDp(int n)
        {
            var dp = new int[n + 1];
        
            for (var i = 1; i <= n; i++) 
            {
                dp[i] = dp[i / 2] + i % 2;
            }
        
            return dp;
        }
        
        private static int[] CountBitsDp2(int n)
        {
            var dp = new int[n + 1];
        
            for (var i = 1; i <= n; i++) 
            {
                dp[i] = dp[i >> 1] + (i & 1);
            }
        
            return dp;
        }
    }
}