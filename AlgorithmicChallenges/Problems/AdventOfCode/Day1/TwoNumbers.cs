namespace AlgorithmicChallenges.Problems.AdventOfCode.Day1
{
    /// <summary>
    /// Find the two entries that sum to 2020 and then multiply those two numbers together.
    /// </summary>
    public static class TwoNumbers
    {
        public static int Run(int[] input)
        {
            const int sum = 2020;
            
            foreach (var num1 in input)
            {
                for (var j = 1; j < input.Length; j++)
                {
                    var num2 = input[j];
                    
                    if (num1 + num2 == sum)
                    {
                        return num1 * num2;
                    }
                }
            }
            
            return 0;
        }
    }
}