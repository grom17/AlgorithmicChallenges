using System;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.ClimbingStairs
{
    /// <summary>
    ///    You are climbing a staircase. It takes n steps to reach the top.
    ///    Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    ///    https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    public static class Solution
    {
        public static int Run(int n, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Fibonacci => Fibonacci(n),
                ESolutionType.Simple => Simple(n),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int Fibonacci(int n)
        {
            n++;
            var ways = new int[n + 1];  
            ways[0]= 0;  
            ways[1]= 1;
            for (var i = 2; i <= n;i++)  
            {  
                ways[i] = ways[i - 2] + ways[i - 1];  
            }  
            return ways[n];
        }
        
        private static int Simple(int n)
        {
            var a = 1;
            var b = 1;
            
            while (n-- > 0)
            {
                a = (b += a) - a;
            }

            return a;
        }
    }
}