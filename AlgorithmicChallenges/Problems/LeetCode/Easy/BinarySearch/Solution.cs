using System;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.BinarySearch
{
    /// <summary>
    ///    Given an array of integers nums which is sorted in ascending order, and an integer target,
    ///    write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
    ///    You must write an algorithm with O(log n) runtime complexity.
    ///    https://leetcode.com/problems/binary-search/
    /// </summary>
    public static class Solution
    {
        public static int Run(int[] nums, int target, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.BinarySearch => BinarySearch(nums, target),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int BinarySearch(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                var current = nums[middle];
                
                if (target == current)
                {
                    return middle;
                }
                
                if (target < current)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            
            return -1;
        }
    }
}