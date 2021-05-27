namespace AlgorithmicChallenges.Tests.Problems.AdventOfCode.Day2
{
    using AlgorithmicChallenges.Problems.AdventOfCode.Day2;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class Part2Tests
    {
        [Test]
        public void TestWithSample()
        {
            // Arrange
            var input = new[] { @"1-3 a: abcde", @"1-3 b: cdefg", @"2-9 c: ccccccccc" };
            const int expectedResult = 1;

            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Part2Solution.Run(input));

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
            var (result, timeElapsed) = RunWithStopwatch(() => Part2Solution.Run(input));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}