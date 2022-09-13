using System;
using AlgorithmicChallenges.Problems.LeetCode.Easy.NumberOf1Bits;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;
    
    [TestFixture]
    public class NumberOf1BitsTests
    {
        [TestCase("00000000000000000000000000001011", ESolutionType.Sparse, ExpectedResult = 3)]
        [TestCase("00000000000000000000000010000000", ESolutionType.Sparse, ExpectedResult = 1)]
        [TestCase("11111111111111111111111111111101", ESolutionType.Sparse, ExpectedResult = 31)]
        [TestCase("00000000000000000000000000001011", ESolutionType.Iterated, ExpectedResult = 3)]
        [TestCase("00000000000000000000000010000000", ESolutionType.Iterated, ExpectedResult = 1)]
        [TestCase("11111111111111111111111111111101", ESolutionType.Iterated, ExpectedResult = 31)]
        [TestCase("00000000000000000000000000001011", ESolutionType.Iterated2, ExpectedResult = 3)]
        [TestCase("00000000000000000000000010000000", ESolutionType.Iterated2, ExpectedResult = 1)]
        [TestCase("11111111111111111111111111111101", ESolutionType.Iterated2, ExpectedResult = 31)]
        public int Test(string input, ESolutionType solutionType)
        {
            var n = Convert.ToUInt32(input, 2);
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}