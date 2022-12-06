using System;
using System.Collections.Generic;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.MinCostClimbingStairs
{
    /// <summary>
    ///    You are given an integer array cost where cost[i] is the cost of ith step on a staircase.
    ///    Once you pay the cost, you can either climb one or two steps.
    ///    You can either start from the step with index 0, or the step with index 1.
    ///    Return the minimum cost to reach the top of the floor.
    ///    https://leetcode.com/problems/min-cost-climbing-stairs
    /// </summary>
    public static class Solution
    {
        public static int Run(int[] costs, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.BottomUpDynamicProgramming => BottomUpDynamicProgramming(costs),
                ESolutionType.TopDownDynamicProgramming => TopDownDynamicProgramming(costs),
                ESolutionType.BottomUpConstantSpace => BottomUpConstantSpace(costs),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }
        
        private static int BottomUpDynamicProgramming(int[] cost)
        {
            var minimumCost = new int[cost.Length + 1];
            
            for (var i = 2; i < minimumCost.Length; i++) 
            {
                var takeOneStep = minimumCost[i - 1] + cost[i - 1];
                var takeTwoSteps = minimumCost[i - 2] + cost[i - 2];
                minimumCost[i] = Math.Min(takeOneStep, takeTwoSteps);
            }
            
            return minimumCost[^1];
        }
        
        private static Dictionary<int, int> _memo = new();
        
        private static int TopDownDynamicProgramming(int[] cost)
        {
            _memo = new Dictionary<int, int>();
            return GetMinimumCost(cost.Length, cost);
        }
        
        private static int GetMinimumCost(int i, IReadOnlyList<int> cost) 
        {
            if (i <= 1) 
            {
                return 0;
            }

            if (_memo.ContainsKey(i)) 
            {
                return _memo[i];
            }

            var downOne = cost[i - 1] + GetMinimumCost(i - 1, cost);
            var downTwo = cost[i - 2] + GetMinimumCost(i - 2, cost);
            _memo[i] = Math.Min(downOne, downTwo);
            return _memo[i];
        }

        private static int BottomUpConstantSpace(int[] cost)
        {
            var downOne = 0;
            var downTwo = 0;
            
            for (var i = 2; i < cost.Length + 1; i++) 
            {
                var temp = downOne;
                downOne = Math.Min(downOne + cost[i - 1], downTwo + cost[i - 2]);
                downTwo = temp;
            }
        
            return downOne;
        }
    }
}