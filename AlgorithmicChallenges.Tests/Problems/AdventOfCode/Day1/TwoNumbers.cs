namespace AlgorithmicChallenges.Tests.Problems.AdventOfCode.Day1
{
    using AlgorithmicChallenges.Problems.AdventOfCode.Day1;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class TwoNumbersTests
    {
        [Test]
        public void TestWithSample()
        {
            // Arrange
            var input = new[] { 1721, 979, 366, 299, 675, 1456 };
            const int expectedResult = 514579;

            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => TwoNumbers.Run(input));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");
            
            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [Test]
        public void TestWithInput()
        {
            // Arrange
            var input = TestData.GetDay1Input();

            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => TwoNumbers.Run(input));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}