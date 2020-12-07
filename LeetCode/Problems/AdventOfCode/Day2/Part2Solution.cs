namespace LeetCode.Problems.AdventOfCode.Day2
{
    using System.Linq;

    /// <summary>
    /// https://adventofcode.com/2020/day/2
    /// </summary>
    public static class Part2Solution
    {
        public static int Run(string[] input)
        {
            var validPasswordsCount = 0;

            foreach (var passwordPolicy in input)
            {
                var passwordPolicyParts = passwordPolicy.Split(' ').ToArray();
                var positions = passwordPolicyParts[0].Split('-');
                var position1 = int.Parse(positions[0]) - 1;
                var position2 = int.Parse(positions[1]) - 1;

                var letter = passwordPolicyParts[1][0];

                var passwordToCheck = passwordPolicyParts[2];

                var letterInPosition1 = passwordToCheck[position1];
                var letterInPosition2 = passwordToCheck[position2];

                if ((letterInPosition1 == letter || letterInPosition2 == letter) && letterInPosition1 != letterInPosition2)
                {
                    validPasswordsCount++;
                }
            }
            
            return validPasswordsCount;
        }
    }
}