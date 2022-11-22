using System;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.FindPivotIndex
{
    /// <summary>
    ///    Given an array of integers nums, calculate the pivot index of this array.
    ///    The pivot index is the index where the sum of all the numbers strictly to the left of the index
    ///    is equal to the sum of all the numbers strictly to the index's right.
    ///    If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left.
    ///    This also applies to the right edge of the array.
    ///    Return the leftmost pivot index. If no such index exists, return -1.
    ///    https://leetcode.com/problems/find-pivot-index
    /// </summary>
    public static class Solution
    {
        public static int Run(int[] nums, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.FindPivotIndex => FindPivotIndex(nums),
                ESolutionType.Best => Best(nums),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int FindPivotIndex(int[] nums)
        {
            var sums = new (int LeftSum, int RightSum)[nums.Length];
            var totalSum = nums.Sum();

            for (var pivotIndex = 0; pivotIndex < nums.Length; pivotIndex++)
            {
                if (pivotIndex == 0)
                {
                    sums[pivotIndex] = (0, totalSum - nums[0]);
                }
                else if (pivotIndex == nums.Length - 1)
                {
                    sums[pivotIndex] = (totalSum - nums[^1], 0); // nums[^1] the same as nums[nums.Length - 1]
                }
                else
                {
                    var currentNum = nums[pivotIndex];
                    var previousPivotIndex = pivotIndex - 1;
                    var previousNum = nums[previousPivotIndex];
                    
                    var leftSum = sums[previousPivotIndex].LeftSum + previousNum;
                    var rightSum = sums[previousPivotIndex].RightSum - currentNum;
                    
                    sums[pivotIndex] = (leftSum, rightSum);
                }

                if (sums[pivotIndex].LeftSum == sums[pivotIndex].RightSum)
                {
                    return pivotIndex;
                }
            }

            return -1;
        }

        private static int Best(int[] nums)
        {
            var totalSum = nums.Sum();
            var leftSum = 0;

            for (var pivotIndex = 0; pivotIndex < nums.Length; pivotIndex++)
            {
                var currentNum = nums[pivotIndex];
                if (leftSum == totalSum - leftSum - currentNum)
                {
                    return pivotIndex;
                }

                leftSum += currentNum;
            }

            return -1;
        }
    }
}