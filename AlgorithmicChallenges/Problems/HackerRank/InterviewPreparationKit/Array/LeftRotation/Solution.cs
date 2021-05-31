namespace AlgorithmicChallenges.Problems.HackerRank.InterviewPreparationKit.Array.LeftRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays</summary>
    public static class Solution
    {
        public static List<int> Run(List<int> a, int d, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.My => My(a, d),
                ESolutionType.Best => Best(a, d),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static List<int> My(List<int> a, int d)
        {
            var result = new List<int>();
            var length = a.Count;

            if (d == length)
            {
                return a;
            }

            if (d > length)
            {
                d = length % d;
            }

            for (var i = d; i < length; i++)
            {
                result.Add(a[i]);
            }

            for (var i = 0; i < d; i++)
            {
                result.Add(a[i]);
            }

            return result;
        }
        
        private static List<int> Best(List<int> a, int d)
        {
            var length = a.Count;
            
            var rotatedLeftA = new int[length];
            for(var i = 0; i < length; i++) 
            {
                var rotatedLeftAIndex = i - d < 0 
                    ? length - d + i 
                    : i -d;
                
                rotatedLeftA[rotatedLeftAIndex] = a[i];
            }
            
            return rotatedLeftA.ToList();
        }
    }
}