using AlgorithmicChallenges.Problems.LeetCode.Easy.CountingBits;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;
    
    [TestFixture]
    public class CountingBitsTests
    {
        [TestCase(2, ESolutionType.CountBitsIterated, ExpectedResult = new[] { 0, 1, 1 })]
        [TestCase(5, ESolutionType.CountBitsIterated, ExpectedResult = new[] { 0, 1, 1, 2, 1, 2 })]
        [TestCase(2, ESolutionType.CountBitsDpWithOffset, ExpectedResult = new[] { 0, 1, 1 })]
        [TestCase(5, ESolutionType.CountBitsDpWithOffset, ExpectedResult = new[] { 0, 1, 1, 2, 1, 2 })]
        [TestCase(2, ESolutionType.CountBitsDp, ExpectedResult = new[] { 0, 1, 1 })]
        [TestCase(5, ESolutionType.CountBitsDp, ExpectedResult = new[] { 0, 1, 1, 2, 1, 2 })]
        [TestCase(2, ESolutionType.CountBitsDp2, ExpectedResult = new[] { 0, 1, 1 })]
        [TestCase(5, ESolutionType.CountBitsDp2, ExpectedResult = new[] { 0, 1, 1, 2, 1, 2 })]
        public int[] Test(int n, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}