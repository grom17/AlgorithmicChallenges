namespace AlgorithmicChallenges.Problems.AdventOfCode.Day4
{
    using System;
    using System.Linq;

    /// <summary>
    /// https://adventofcode.com/2020/day/4
    /// </summary>
    public static class Part1Solution
    {
        public static int Run(string input)
        {
            var expectedFields = new[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
            
            var passports = input.Split(new[] { Environment.NewLine + Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            return passports
                .Select(passport => expectedFields.All(passport.Contains))
                .Count(containsAllExpectedFields => containsAllExpectedFields);
        }
    }
}