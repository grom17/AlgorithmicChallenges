namespace AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.RepeatedString
{
    using System.Linq;

    /// <summary>https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup</summary>
    public static class Solution
    {
        public static long Run(string s, long n)
        {
            static int CountA(string input)
            {
                return input.Count(x => x == 'a');
            }
            
            var croppedPatternLength = (int)(n % s.Length);
            var countAInCroppedPattern = CountA(s[..croppedPatternLength]);
            return n / s.Length * CountA(s) + countAInCroppedPattern;
        }
    }
}