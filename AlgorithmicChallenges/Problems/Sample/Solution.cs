using System;

namespace AlgorithmicChallenges.Problems.Sample
{
    /// <summary>Description</summary>
    public static class Solution
    {
        public static int Run(int input, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Solution1 => Solution1(input),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int Solution1(int input)
        {
            return input;
        }
    }
}