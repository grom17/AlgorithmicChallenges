namespace AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.CountingValleys
{
    using System;

    /// <summary>https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup</summary>
    public static class Solution
    {
        public static int Run(int steps, string path, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.My => My(steps, path),
                ESolutionType.Best => Best(steps, path),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }
        
        private static int My(int steps, string path)
        {
            var level = 0;
            var isInValley = false;
            var valleyCount = 0;

            for (var i = 0; i < steps; i++)
            {
                level += path[i] == 'U' ? 1 : -1;

                if (level == 0 && isInValley)
                {
                    valleyCount++;
                    isInValley = false;
                }

                if (level < 0 && !isInValley)
                {
                    isInValley = true;
                }
            }
            
            return valleyCount;
        }

        private static int Best(int steps, string path)
        {
            var level = 0;
            var valleyCount = 0;

            for (var i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (++level == 0)
                    {
                        valleyCount++;
                    }
                }
                else
                {
                    level--;
                }
            }

            return valleyCount;
        }
    }
}