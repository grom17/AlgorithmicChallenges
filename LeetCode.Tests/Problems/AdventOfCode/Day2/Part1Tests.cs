namespace LeetCode.Tests.Problems.AdventOfCode.Day2
{
    using LeetCode.Problems.AdventOfCode.Day2;
    using NUnit.Framework;
    
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class Part1Tests
    {
        [Test]
        public void TestWithSample()
        {
            // Arrange
            var input = new[] { @"1-3 a: abcde", @"1-3 b: cdefg", @"2-9 c: ccccccccc" };
            const int expectedResult = 2;

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
            var input = TestData.GetDay2Input();
            
            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Part1Solution.Run(input));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}