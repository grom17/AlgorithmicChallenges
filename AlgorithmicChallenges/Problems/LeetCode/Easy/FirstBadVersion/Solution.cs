using System;

namespace AlgorithmicChallenges.Problems.LeetCode.Easy.FirstBadVersion
{
    /// <summary>
    ///    You are a product manager and currently leading a team to develop a new product.
    ///    Unfortunately, the latest version of your product fails the quality check.
    ///    Since each version is developed based on the previous version, all the versions after a bad version are also bad.
    ///    Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
    ///    You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version.
    ///    You should minimize the number of calls to the API.
    ///    https://leetcode.com/problems/first-bad-version
    /// </summary>
    public static class Solution
    {
        public static int Run(int n, int bad, ESolutionType solutionType)
        {
            _badVersion = bad;
            return solutionType switch
            {
                ESolutionType.BinarySearch => BinarySearch(n),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int _badVersion;

        private static int BinarySearch(int n)
        {
            var left = 1;
            var right = n;
            
            while (left < right)
            {
                var middle = left + (right - left) / 2;
                var isBadVersion = IsBadVersion(middle);

                if (isBadVersion)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }
            
            return left;
        }

        private static bool IsBadVersion(int n)
        {
            return n == _badVersion;
        }
    }
}