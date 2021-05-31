namespace AlgorithmicChallenges.Tests.Problems.HackerRank.InterviewPreparationKit.Array.TwoDimArrayDs
{
    using System.Collections.Generic;
    using AlgorithmicChallenges.Problems.HackerRank.InterviewPreparationKit.Array.TwoDimArrayDs;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;
    
    [TestFixture]
    public class TwoDimArrayDsTests
    {
        [Test]
        public void TestCase1()
        {
            // Arrange
            var list = new List<List<int>>
            {
                new() { -9, -9, -9,  1, 1, 1 },
                new() { -0, -9,  0,  4, 3, 2 },
                new() { -9, -9, -9,  1, 2, 3 },
                new() {  0,  0,  8,  6, 6, 0 },
                new() {  0,  0,  0, -2, 0, 0 },
                new() {  0,  0,  1,  2, 4, 0 }
            };

            var expectedResult = 28;
            
            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(list));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [Test]
        public void TestCase2()
        {
            // Arrange
            var list = new List<List<int>>
            {
                new() { 1, 1, 1, 0, 0, 0 },
                new() { 0, 1, 0, 0, 0, 0 },
                new() { 1, 1, 1, 0, 0, 0 },
                new() { 0, 0, 2, 4, 4, 0 },
                new() { 0, 0, 0, 2, 0, 0 },
                new() { 0, 0, 1, 2, 4, 0 }
            };

            var expectedResult = 19;
            
            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(list));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [Test]
        public void TestCase3()
        {
            // Arrange
            var list = new List<List<int>>
            {
                new() { 1, 1,  1,  0,  0, 0 },
                new() { 0, 1,  0,  0,  0, 0 },
                new() { 1, 1,  1,  0,  0, 0 },
                new() { 0, 9,  2, -4, -4, 0 },
                new() { 0, 0,  0, -2,  0, 0 },
                new() { 0, 0, -1, -2, -4, 0 }
            };

            var expectedResult = 13;
            
            // Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(list));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}