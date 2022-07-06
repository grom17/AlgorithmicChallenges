using System;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.BestTimeToBuyAndSellStock
{
    /// <summary>
    ///  You are given an array prices where prices[i] is the price of a given stock on the ith day.
    ///  You want to maximize your profit by choosing a single day to buy one stock and
    ///   choosing a different day in the future to sell that stock.
    ///  Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public static class Solution
    {
        public static int Run(int[] prices, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.BruteForce => BruteForce(prices),
                ESolutionType.MinPrice => MinPrice(prices),
                ESolutionType.OnePass => OnePass(prices),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int BruteForce(int[] prices)
        {
            var maxProfit = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    var profit = prices[j] - prices[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }

        private static int MinPrice(int[] prices)
        {
            var maxProfit = 0;
            var minPrice = int.MaxValue;

            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] >= minPrice)
                {
                    continue;
                }

                minPrice = prices[i];

                for (var j = i + 1; j < prices.Length; j++)
                {
                    var profit = prices[j] - prices[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }
        
        private static int OnePass(int[] prices)
        {
            var maxProfit = 0;
            var minPrice = int.MaxValue;

            foreach (var price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else if (price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }
            }

            return maxProfit;
        }
    }
}