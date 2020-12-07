namespace LeetCode.Tests.Problems.AdventOfCode
{
    using System;
    using System.IO;
    using System.Linq;

    public static class TestData
    {
        public static int[] GetDay1Input()
        {
            return GetInputAsString(1)
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .ToArray();
        }
        
        public static string[] GetDay2Input()
        {
            return GetInputAsString(2)
                .Split(Environment.NewLine)
                .ToArray();
        }
        
        public static string[] GetDay3Input()
        {
            return GetInputAsString(3)
                .Split(Environment.NewLine)
                .ToArray();
        }
        
        public static string GetDay4Input()
        {
            return GetInputAsString(4);
        }

        private static string GetInputAsString(int dayNo)
        {
            return File.ReadAllText($@"Problems\AdventOfCode\Day{dayNo}\Input.txt");
        }
    }
}