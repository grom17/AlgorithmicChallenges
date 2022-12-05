using System;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.FibonacciNumber
{
    /// <summary>
    ///    The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence,
    ///    such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
    ///    F(0) = 0, F(1) = 1
    ///    F(n) = F(n - 1) + F(n - 2), for n > 1.
    ///    Given n, calculate F(n).
    ///    https://leetcode.com/problems/fibonacci-number
    /// </summary>
    public static class Solution
    {
        public static int Run(int n, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Recursion => Recursion(n),
                ESolutionType.Iteration => Iteration(n),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int Recursion(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return Recursion(n - 1) + Recursion(n - 2);
        }
        
        private static int Iteration(int n)
        {
            if (n < 2)
            {
                return n;
            }

            var fibNumbers = new int[n + 1];
            fibNumbers[0]= 0;  
            fibNumbers[1]= 1;
            for (var i = 2; i <= n;i++)  
            {  
                fibNumbers[i] = fibNumbers[i - 2] + fibNumbers[i - 1];  
            }  
            return fibNumbers[n];
        }
    }
}