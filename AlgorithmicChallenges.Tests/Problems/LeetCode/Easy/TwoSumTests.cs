using System.Diagnostics;
using AlgorithmicChallenges.Problems.LeetCode.Easy.TwoSum;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    [TestFixture]
    public class TwoSumTests
    {
        [TestCase(new[] {2, 7, 11, 15}, 9, ESolutionType.BruteForce, new[] {0, 1})]
        [TestCase(new[] {3, 3}, 6, ESolutionType.BruteForce, new[] {0, 1})]
        [TestCase(new[] {-3, 2, 3, 90}, 0, ESolutionType.BruteForce, new[] {0, 2})]
        [TestCase(new[] {2, 7, 11, 15}, 9, ESolutionType.Dictionary, new[] {0, 1})]
        [TestCase(new[] {3, 3}, 6, ESolutionType.Dictionary, new[] {0, 1})]
        [TestCase(new[] {-3, 2, 3, 90}, 0, ESolutionType.Dictionary, new[] {0, 2})]
        public void Test(int[] nums, int target, ESolutionType solutionType, int[] expectedResult)
        {
            var sw = new Stopwatch();

            sw.Start();
            
            // Arrange & Act
            var result = Solution.Run(nums, target, solutionType);

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [Test]
        public void TestThrows()
        {
            Assert.That(() => Solution.Run(new[] {0, 3}, 6, ESolutionType.BruteForce), Throws.ArgumentException);
        }
    }
}