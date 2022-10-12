using AlgorithmicChallenges.Problems.LeetCode.Easy.ClimbingStairs;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class ClimbingStairsTests
    {
        [TestCase(2, ESolutionType.Fibonacci, ExpectedResult = 2)]
        [TestCase(3, ESolutionType.Fibonacci, ExpectedResult = 3)]
        [TestCase(5, ESolutionType.Fibonacci, ExpectedResult = 8)]
        [TestCase(2, ESolutionType.Simple, ExpectedResult = 2)]
        [TestCase(3, ESolutionType.Simple, ExpectedResult = 3)]
        [TestCase(5, ESolutionType.Simple, ExpectedResult = 8)]
        public int Test(int n, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}