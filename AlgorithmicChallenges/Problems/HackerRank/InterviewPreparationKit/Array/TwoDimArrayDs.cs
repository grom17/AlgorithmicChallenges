namespace AlgorithmicChallenges.Problems.HackerRank.InterviewPreparationKit.Array
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays</summary>
    public static class Solution
    {
        public static long Run(List<List<int>> arr)
        {
            var sums = new List<int>();

            for (var r = 0; r < 4; r++)
            {
                for (var c = 0; c < 4; c++)
                {
                    sums.Add(GetHourglassSum(arr, r, c));
                }
            }
            
            return sums.Max();
        }

        private static int GetHourglassSum(List<List<int>> arr, int row, int column)
        {
            return arr[row][column] + arr[row][column + 1] + arr[row][column + 2] + 
                   arr[++row][column + 1] + 
                   arr[++row][column] + arr[row][column + 1] + arr[row][column + 2];
        }
    }
}