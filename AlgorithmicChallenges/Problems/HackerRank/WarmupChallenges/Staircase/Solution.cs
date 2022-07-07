using System;

namespace AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.Staircase
{
    using System.Text;

    /// <summary>https://www.hackerrank.com/challenges/staircase/problem</summary>
    public static class Solution
    {
        public static string Run(int n)
        {
            var sb = new StringBuilder();
            var row = "";
            
            for (var i = 1; i <= n; i++)
            {
                row += "#";
                sb.Append($"{row.PadLeft(n)}{Environment.NewLine}");
            }

            return sb.ToString().TrimEnd('\n').TrimEnd('\r');
        }
    }
}