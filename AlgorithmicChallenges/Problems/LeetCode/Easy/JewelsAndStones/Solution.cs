using System;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.JewelsAndStones
{
    /// <summary>
    ///  You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have.
    ///  Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
    ///  Letters are case sensitive, so "a" is considered a different type of stone from "A".
    ///  https://leetcode.com/problems/jewels-and-stones/
    /// </summary>
    public static class Solution
    {
        public static int Run(string jewels, string stones, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.LinqWithGroupBy => LinqWithGroupBy(jewels, stones),
                ESolutionType.Linq => Linq(jewels, stones),
                ESolutionType.Loops => Loops(jewels, stones),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int LinqWithGroupBy(string jewels, string stones)
        {
            var jewelsArray = jewels.ToCharArray();
            return stones.ToCharArray()
                .Where(s => jewelsArray.Contains(s))
                .GroupBy(s => s)
                .Select(gr => gr.Count())
                .Sum();
        }

        private static int Linq(string jewels, string stones)
        {
            return stones.Count(jewels.Contains);
        }
        
        private static int Loops(string jewels, string stones)
        {
            var num = 0;
        
            foreach (var stone in stones)
            {
                foreach (var jewel in jewels)
                {
                    if (stone == jewel)
                    {
                        num++;
                    }
                }
            }
        
            return num;
        }
    }
}