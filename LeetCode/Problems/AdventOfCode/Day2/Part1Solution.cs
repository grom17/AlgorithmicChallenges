namespace LeetCode.Problems.AdventOfCode.Day2
{
    using System.Linq;

    /// <summary>
    /// https://adventofcode.com/2020/day/2
    /// </summary>
    public static class Part1Solution
    {
        public static int Run(string[] input)
        {
            var validPasswordsCount = 0;

            foreach (var passwordPolicy in input)
            {
                var passwordPolicyParts = passwordPolicy.Split(' ').ToArray();
                var limits = passwordPolicyParts[0].Split('-');
                var lowerBound = int.Parse(limits[0]);
                var upperBound = int.Parse(limits[1]);

                var letter = passwordPolicyParts[1][0];

                var passwordToCheck = passwordPolicyParts[2];

                var count = passwordToCheck.Count(ch => ch == letter);

                if (lowerBound <= count && count <= upperBound)
                {
                    validPasswordsCount++;
                }
            }
            
            return validPasswordsCount;
        }
    }
}