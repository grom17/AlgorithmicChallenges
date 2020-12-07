namespace LeetCode.Tests.Problems.AdventOfCode.Day3
{
    using System;
    using System.Diagnostics;
    using LeetCode.Problems.AdventOfCode.Day3;
    using NUnit.Framework;

    [TestFixture]
    public class Part2Tests
    {
        [Test]
        public void TestWithSample()
        {
            // Arrange
            var input = @"..##.......
#...#...#..
.#....#..#.
..#.#...#.#
.#...##..#.
..#.##.....
.#.#.#....#
.#........#
#.##...#...
#...##....#
.#..#...#.#"
                .Split(Environment.NewLine);
            
            const int expectedResult = 336;
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = Part2Solution.Run(input);

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");
            TestContext.Out.WriteLine($"Result={result}");
            
            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [Test]
        public void TestWithInput()
        {
            // Arrange
            var input = TestData.GetDay3Input();
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = Part2Solution.Run(input);

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}