using System.Collections.Generic;

namespace AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.SalesByMatch
{
    using System;
    using System.Linq;

    /// <summary>https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup</summary>
    public static class Solution
    {
        public static int Run(int n, List<int> ar, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.GroupBy => GroupBy(n, ar),
                ESolutionType.Loops => Loops(n, ar),
                ESolutionType.HashSet => HashSet(n, ar),
                ESolutionType.Lookup => Lookup(n, ar),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }
        
        private static int GroupBy(int n, IEnumerable<int> ar)
        {
            var result = ar
                .GroupBy(x => x)
                .Sum(x => x.Count() / 2);
            
            return result;
        }
        
        private static int Loops(int n, IReadOnlyList<int> ar)
        {
            var result = 0;
            var socksCount = new int[101];
            
            for (var i = 0; i < n; i++)
            {
                socksCount[ar[i]]++;
            }

            for (var i = 0; i < 101; i++)
            {
                result += socksCount[i] / 2;
            }
            
            return result;
        }
        
        private static int HashSet(int n, IReadOnlyList<int> ar)
        {
            var result = 0;
            var colors = new HashSet<int>();
            
            for (var i = 0; i < n; i++)
            {
                if (!colors.Contains(ar[i]))
                {
                    colors.Add(ar[i]);
                }
                else
                {
                    result++;
                    colors.Remove(ar[i]);
                }
            }

            return result;
        }
        
        private static int Lookup(int n, IEnumerable<int> ar)
        {
            var result = ar
                .ToLookup(x => x)
                .Sum(x => x.Count() / 2);
            
            return result;
        }
    }
}