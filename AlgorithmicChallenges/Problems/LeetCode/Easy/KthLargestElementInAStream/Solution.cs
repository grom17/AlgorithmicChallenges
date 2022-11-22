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
                ESolutionType.MySolution => MySolution(k, nums, values),
                ESolutionType.Best => Best(k, nums, values),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }
        
        private static IEnumerable<int> MySolution(int k, int[] nums, int[] values)
        {
            var obj = new MyKthLargest(k, nums);
            
            foreach (var val in values)
            {
                yield return obj.Add(val);
            }
        }
        
        private static IEnumerable<int> Best(int k, int[] nums, int[] values)
        {
            var obj = new BestKthLargest(k, nums);
            
            foreach (var val in values)
            {
                yield return obj.Add(val);
            }
        }
    }

    public class MyKthLargest
    {
        private readonly int _k;

        private readonly List<int> _nums;
        
        public MyKthLargest(int k, IEnumerable<int> nums)
        {
            _k = k;
            _nums = nums.ToList();
        }
    
        public int Add(int val)
        {
            _nums.Add(val);

            return GetKthLargest();
        }

        private int GetKthLargest()
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
    
    public class BestKthLargest
    {
        private readonly PriorityQueue<int, int> _priorityQueue = new();
        
        private readonly int _k;
        
        public BestKthLargest(int k, IEnumerable<int> nums)
        {
            _k = k;
            
            foreach (var num in nums)
            {
                Add(num);
            }
        }
    
        public int Add(int val)
        {
            if (_priorityQueue.Count < _k)
            {
                _priorityQueue.Enqueue(val, val);
            }
            else if (val > _priorityQueue.Peek())
            {
                _priorityQueue.Dequeue();
                _priorityQueue.Enqueue(val, val);
            }

            return _priorityQueue.Peek();
        }
    }
}