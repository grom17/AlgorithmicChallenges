namespace LeetCode.Problems.AdventOfCode.Day4
{
    using System.Linq;
    using Services;

    /// <summary>
    /// https://adventofcode.com/2020/day/4
    /// </summary>
    public static class Part2Solution
    {
        public static int Run(string input)
        {
            var passports = new PassportParser().Parse(input);

            var validator = new PassportValidator();

            return passports.Count(p => validator.Validate(p).IsValid);
        }
    }
}