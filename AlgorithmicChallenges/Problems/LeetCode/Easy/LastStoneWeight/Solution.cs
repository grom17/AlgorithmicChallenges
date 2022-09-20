// ReSharper disable InvalidXmlDocComment
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.LastStoneWeight
{
    /// <summary>
    ///    You are given an array of integers stones where stones[i] is the weight of the ith stone.
    ///    We are playing a game with the stones. On each turn, we choose the heaviest two stones and smash them together.
    ///    Suppose the heaviest two stones have weights x and y with x <= y. The result of this smash is:
    ///       If x == y, both stones are destroyed, and
    ///       If x != y, the stone of weight x is destroyed, and the stone of weight y has new weight y - x.
    ///    At the end of the game, there is at most one stone left.
    ///    Return the weight of the last remaining stone. If there are no stones left, return 0.
    ///    https://leetcode.com/problems/last-stone-weight/
    /// </summary>
    public static class Solution
    {
        public static int Run(int[] stones, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.PriorityQueue => PriorityQueue(stones),
                ESolutionType.Foreach => Foreach(stones),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int PriorityQueue(int[] stones)
        {
            var priorityQueue = new PriorityQueue<int, int>();

            foreach (var stone in stones)
            {
                priorityQueue.Enqueue(stone, -stone);
            }

            while (priorityQueue.Count > 1)
            {
                var newWeight = priorityQueue.Dequeue() - priorityQueue.Dequeue();

                if (newWeight != 0)
                {
                    priorityQueue.Enqueue(newWeight, -newWeight);
                }
            }

            return priorityQueue.Count == 1 ? priorityQueue.Peek() : 0;
        }

        private static int Foreach(int[] stones)
        {
            var list = stones.ToList();
            while (list.Count > 1)
            {
                var (max, secondMax) = GetMaximums(list);
                list.Remove(max);
                list.Remove(secondMax);
                if (max != secondMax)
                {
                    list.Add(max - secondMax);
                }
            }

            return list.FirstOrDefault();
        }

        private static (int max, int secondMax) GetMaximums(ICollection<int> items)
        {
            var max = 0;
            var secondMax = 0;
            
            foreach (var item in items)
            {
                if (item >= max)
                {
                    secondMax = max;
                    max = item;
                }
                else if (item >= secondMax)
                {
                    secondMax = item;
                }
            }

            return (max, secondMax);
        }
    }
}