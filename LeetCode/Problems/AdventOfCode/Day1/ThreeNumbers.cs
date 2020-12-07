namespace LeetCode.Problems.AdventOfCode.Day1
{
    /// <summary>
    /// Find the three entries that sum to 2020 and then multiply those numbers together.
    /// </summary>
    public static class ThreeNumbers
    {
        public static int Run(int[] input)
        {
            const int sum = 2020;
            
            foreach (var num1 in input)
            {
                for (var j = 1; j < input.Length; j++)
                {
                    var num2 = input[j];

                    var sumOfNum1AndNum2 = num1 + num2;

                    if (sumOfNum1AndNum2 >= sum)
                    {
                        continue;
                    }
                    
                    for (var k = 2; k < input.Length; k++)
                    {
                        var num3 = input[k];
                        
                        if (sumOfNum1AndNum2 + num3 == sum)
                        {
                            return num1 * num2 * num3;
                        }
                    }
                }
            }
            
            return 0;
        }
    }
}