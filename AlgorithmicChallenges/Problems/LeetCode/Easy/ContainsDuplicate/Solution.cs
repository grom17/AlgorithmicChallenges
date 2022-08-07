using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.ContainsDuplicate
{
    /// <summary>
    ///    Given an integer array nums, return true if any value appears at least twice in the array,
    ///    and return false if every element is distinct.
    ///    https://leetcode.com/problems/contains-duplicate/
    /// </summary>
    public static class Solution
    {
        public static bool Run(int[] nums, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.Linq => Linq(nums),
                ESolutionType.ForeachWithHashSet => ForeachWithHashSet(nums),
                ESolutionType.ArrayToHashSet => ArrayToHashSet(nums),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static bool Linq(int[] nums)
        {
            return nums.GroupBy(n => n).Any(g => g.Count() > 1);
        }

        private static bool ForeachWithHashSet(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (var num in nums)
            {
                if (hashSet.Contains(num))
                {
                    return true;
                }

                hashSet.Add(num);
            }
            
            return false;
        }
        
        private static bool ArrayToHashSet(int[] nums)
        {
            return nums.ToHashSet().Count != nums.Length;
        }
    }
}