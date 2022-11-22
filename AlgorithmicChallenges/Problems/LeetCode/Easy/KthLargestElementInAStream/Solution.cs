using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.KthLargestElementInAStream
{
    /// <summary>
    ///    Design a class to find the kᵗʰ largest element in a stream. Note that it is the 
    ///    kᵗʰ largest element in the sorted order, not the kᵗʰ distinct element. 
    ///    Implement KthLargest class: 
    ///    KthLargest(int k, int[] nums) Initializes the object with the integer k and 
    ///    the stream of integers nums. 
    ///    int add(int val) Appends the integer val to the stream and returns the element 
    ///    representing the kᵗʰ largest element in the stream.
    ///    https://leetcode.com/problems/kth-largest-element-in-a-stream/
    /// </summary>
    public static class Solution
    {
        public static IEnumerable<int> Run(int k, int[] nums, int[] values, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.KthLargest => Execute(k, nums, values),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }
        
        private static IEnumerable<int> Execute(int k, int[] nums, int[] values)
        {
            var obj = new KthLargest(k, nums);
            
            foreach (var val in values)
            {
                yield return obj.Add(val);
            }
        }
    }

    public class KthLargest
    {
        private readonly int _k;

        private readonly List<int> _nums;
        
        public KthLargest(int k, IEnumerable<int> nums)
        {
            _k = k;
            _nums = nums.ToList();
        }
    
        public int Add(int val)
        {
            _nums.Add(val);

            return GetLargest();
        }

        private int GetLargest()
        {
            var priorityQueue = new PriorityQueue<int, int>();

            foreach (var num in _nums)
            {
                priorityQueue.Enqueue(num, -num);
            }

            for (var i = 1; i < _k; i++)
            {
                priorityQueue.Dequeue();
            }
            
            return priorityQueue.Peek();
        }
    }
}