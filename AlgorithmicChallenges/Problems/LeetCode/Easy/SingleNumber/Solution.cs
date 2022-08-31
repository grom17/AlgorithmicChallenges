using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.SingleNumber
{
    /// <summary>
    ///    Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    ///    You must implement a solution with a linear runtime complexity and use only constant extra space.
    /// </summary>
    public static class Solution
    {
        public static int Run(int[] nums, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.GroupBy => GroupBy(nums),
                ESolutionType.HashSet => HashSet(nums),
                ESolutionType.Xor => Xor(nums),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int GroupBy(int[] nums)
        {
            return nums.GroupBy(n => n).Single(g => g.Count() == 1).Key;
        }
        
        private static int HashSet(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!hashSet.Contains(num))
                {
                    hashSet.Add(num);
                }
                else
                {
                    hashSet.Remove(num);
                }
            }

            return hashSet.Single();
        }

        private static int Xor(int[] nums)
        {
            var ans = 0;

            foreach (var num in nums)
            {
                ans ^= num;
            }

            return ans;
        }
    }
}