namespace AlgorithmicChallenges.Problems.AdventOfCode.Day3
{
    using System.Text;

    /// <summary>
    /// https://adventofcode.com/2020/day/3
    /// </summary>
    public static class Part1Solution
    {
        public static int Run(string[] input)
        {
            var treesCount = 0;
            var position = 0;

            for (var i = 1; i < input.Length; i++)
            {
                var row = input[i];
                position += 3;

                if (row.Length <= position)
                {
                    var sb = new StringBuilder(row);
                    while (sb.Length <= position)
                    {
                        sb.Append(row);
                    }

                    row = sb.ToString();
                }

                if (row[position] == '#')
                {
                    treesCount++;
                }
            }
            
            return treesCount;
        }
    }
}