namespace AlgorithmicChallenges.Problems.HackerRank.InterviewPreparationKit.Array.MinimumSwaps2
{
    using System;
    using System.Linq;

    /// <summary>https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays&page=10168</summary>
    public static class Solution
    {
        public static int Run(int[] arr, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.My => My(arr),
                ESolutionType.Best => Best(arr),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int My(int[] arr)
        {
            var swaps = 0;

            for (
                var unsortedPartLastIndex = arr.Length - 1; 
                unsortedPartLastIndex > 0; 
                unsortedPartLastIndex--)
            {
                var croppedArray = arr.Take(unsortedPartLastIndex + 1).ToArray();
                var maxValueIndex = Array.LastIndexOf(croppedArray, croppedArray.Max());

                if (maxValueIndex == unsortedPartLastIndex)
                {
                    continue;
                }
            
                arr[maxValueIndex] = arr[unsortedPartLastIndex];
                swaps++;
            }

            return swaps;
        }

        private static int Best(int[] arr)
        {
            var i = 0;
            var swaps = 0;
            int temp;
            
            while(i < arr.Length)
            {
                if (arr[i] != i + 1)
                {
                    temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;
                    swaps++;
                }
                else
                {
                    i++;
                }
            }
            
            return swaps;
        }
    }
}