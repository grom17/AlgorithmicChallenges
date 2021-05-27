using System;
using System.Collections.Generic;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.TwoSum
{
    /// <summary>
    ///    Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    ///    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// </summary>
    public static class Solution
    {
        public static int[] Run(int[] nums, int target, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.BruteForce => BruteForce(nums, target),
                ESolutionType.Dictionary => Dictionary(nums, target),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int[] BruteForce(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }

            throw new ArgumentException(Constants.NoSolution);
        }

        private static int[] Dictionary(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dict.ContainsKey(diff))
                {
                    return new[] {dict[diff], i};
                }

                dict.TryAdd(nums[i], i);
            }

            throw new ArgumentException(Constants.NoSolution);
        }
    }
}