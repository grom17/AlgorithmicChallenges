using AlgorithmicChallenges.Problems.LeetCode.Easy.FibonacciNumber;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class FibonacciNumberTests
    {
        [TestCase(2, ESolutionType.Recursion, ExpectedResult = 1)]
        [TestCase(3, ESolutionType.Recursion, ExpectedResult = 2)]
        [TestCase(4, ESolutionType.Recursion, ExpectedResult = 3)]
        [TestCase(2, ESolutionType.Iteration, ExpectedResult = 1)]
        [TestCase(3, ESolutionType.Iteration, ExpectedResult = 2)]
        [TestCase(4, ESolutionType.Iteration, ExpectedResult = 3)]
        public int Test(int n, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}