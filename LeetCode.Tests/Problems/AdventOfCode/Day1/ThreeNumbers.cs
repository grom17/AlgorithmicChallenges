namespace LeetCode.Tests.Problems.AdventOfCode.Day1
{
    using System.Diagnostics;
    using LeetCode.Problems.AdventOfCode.Day1;
    using NUnit.Framework;

    [TestFixture]
    public class ThreeNumbersTests
    {
        [Test]
        public void TestWithSample()
        {
            // Arrange
            var input = new[] { 1721, 979, 366, 299, 675, 1456 };
            const int expectedResult = 241861950;
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = ThreeNumbers.Run(input);

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
            var input = TestData.GetDay1Input();
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = ThreeNumbers.Run(input);

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}