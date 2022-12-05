using AlgorithmicChallenges.Problems.LeetCode.Easy.FirstBadVersion;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class FirstBadVersionTests
    {
        [TestCase(5, 4, ESolutionType.BinarySearch, ExpectedResult = 4)]
        [TestCase(1, 1, ESolutionType.BinarySearch, ExpectedResult = 1)]
        public int Test(int n, int bad, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n, bad, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}