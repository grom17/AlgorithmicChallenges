namespace LeetCode.Problems.Easy.ReverseInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>Given a 32-bit signed integer, reverse digits of an integer.</summary>
    public static class Solution
    {
        public static int Run(int x, ESolutionType solutionType)
        {
            return solutionType switch
            {
                ESolutionType.List => List(x),
                ESolutionType.WithoutList => WithoutList(x),
                ESolutionType.Best => Best(x),
                ESolutionType.MyBest => MyBest(x),
                _ => throw new ArgumentOutOfRangeException(nameof(solutionType), solutionType, null)
            };
        }

        private static int Best(int x)
        {
            var rev = 0;
            while (x != 0)
            {
                var pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }

            return rev;
        }

        private static int WithoutList(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }

            var belowZero = false;

            if (x < 0)
            {
                belowZero = true;
                x *= -1;
            }

            long result = 0;
            while (x != 0)
            {
                result = 10 * result + x % 10;

                x /= 10;
            }

            var intResult = result > int.MaxValue ? 0 : (int)result;

            return belowZero ? intResult * -1 : intResult;
        }
        
        private static int MyBest(int x)
        {
            long result = 0;
            while (x != 0)
            {
                result = 10 * result + x % 10;

                x /= 10;
            }

            return result > int.MaxValue || result < int.MinValue ? 0 : (int)result;
        }

        private static int List(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }
            
            var belowZero = x < 0;
            
            x = belowZero ? x * -1 : x;

            var list = new List<long>();
            while (x != 0)
            {
                list.Add(x % 10);
                
                x /= 10;
            }
            
            var result = list.Aggregate(0, (long current, long num) => (10 * current + num));
            
            var intResult = result > int.MaxValue ? 0 : (int)result;

            return belowZero ? intResult * -1 : intResult;
        }
    }
}