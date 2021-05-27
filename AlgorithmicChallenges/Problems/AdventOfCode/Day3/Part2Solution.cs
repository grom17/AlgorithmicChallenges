namespace AlgorithmicChallenges.Problems.AdventOfCode.Day3
{
    using System.Text;

    /// <summary>
    /// https://adventofcode.com/2020/day/3
    /// </summary>
    public static class Part2Solution
    {
        public static long Run(string[] input)
        {
            long result = 1;
            
            var slopes = new (int PositionIncrement, int RowIncrement)[]
            {
                ( 1, 1 ), ( 3, 1 ), ( 5, 1 ), ( 7, 1 ), ( 1, 2 )
            };
            
            foreach (var slope in slopes)
            {
                var position = 0;
                long treesCount = 0;

                for (var i = slope.RowIncrement; i < input.Length; i += slope.RowIncrement)
                {
                    var row = input[i];
                    position += slope.PositionIncrement;

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

                result *= treesCount;
            }

            return result;
        }
    }
}