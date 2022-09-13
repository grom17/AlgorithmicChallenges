using AlgorithmicChallenges.Problems.LeetCode.Easy.HappyNumber;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;
    
    [TestFixture]
    public class HappyNumberTests
    {
        [TestCase(7, ESolutionType.HashSet, ExpectedResult = true)]
        [TestCase(19, ESolutionType.HashSet, ExpectedResult = true)]
        [TestCase(2, ESolutionType.HashSet, ExpectedResult = false)]
        [TestCase(161, ESolutionType.HashSet, ExpectedResult = false)]
        [TestCase(7, ESolutionType.TwoPointers, ExpectedResult = true)]
        [TestCase(19, ESolutionType.TwoPointers, ExpectedResult = true)]
        [TestCase(2, ESolutionType.TwoPointers, ExpectedResult = false)]
        [TestCase(161, ESolutionType.TwoPointers, ExpectedResult = false)]
        public bool Test(int n, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}