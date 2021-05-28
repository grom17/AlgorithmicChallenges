namespace AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.JumpingOnTheClouds
{
    using System;
    using System.Collections.Generic;

    /// <summary>https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup</summary>
    public static class Solution
    {
        public static int Run(List<int> c, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.My => My(c),
                ESolutionType.Best => Best(c),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }
        
        private static int My(List<int> c)
        {
            var jumps = 0;
            var currentCloudIndex = 0;

            var cloudsCount = c.Count;
            for (var i = 0; i < cloudsCount - 1; i++)
            {
                if (i != currentCloudIndex)
                {
                    continue;
                }

                if (i + 2 >= cloudsCount)
                {
                    if (i + 1 != cloudsCount)
                    {
                        jumps++;
                    }
                    
                    break;
                }

                currentCloudIndex += c[i + 2] != 1 ? 2 : 1;

                jumps++;
            }

            return jumps;
        }

        private static int Best(List<int> c)
        {
            var jumps = 0;

            for (var i = 0; i < c.Count - 1; i++, jumps++) 
            {
                if (c[i] == 0)
                {
                    i++;    
                }
            }
            
            return jumps;
        }
    }
}