namespace LeetCode.Tests.Problems.AdventOfCode.Day2
{
    using System.Diagnostics;
    using LeetCode.Problems.AdventOfCode.Day2;
    using NUnit.Framework;

    [TestFixture]
    public class Part1Tests
    {
        [Test]
        public void TestWithSample()
        {
            // Arrange
            var input = new[] { @"1-3 a: abcde", @"1-3 b: cdefg", @"2-9 c: ccccccccc" };
            const int expectedResult = 2;
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = Part1Solution.Run(input);

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
            var input = TestData.GetDay2Input();
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = Part1Solution.Run(input);

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}