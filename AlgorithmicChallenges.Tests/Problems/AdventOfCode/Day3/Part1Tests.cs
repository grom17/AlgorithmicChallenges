namespace AlgorithmicChallenges.Tests.Problems.AdventOfCode.Day3
{
    using System;
    using AlgorithmicChallenges.Problems.AdventOfCode.Day3;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class Part1Tests
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
            
            const int expectedResult = 7;

            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Part1Solution.Run(input));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");
            
            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [Test]
        public void TestWithInput()
        {
            // Arrange
            var input = TestData.GetDay3Input();

            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Part1Solution.Run(input));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}