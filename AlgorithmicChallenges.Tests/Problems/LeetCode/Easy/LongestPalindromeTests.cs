using AlgorithmicChallenges.Problems.LeetCode.Easy.LongestPalindrome;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class LongestPalindromeTests
    {
        [TestCase("abccccdd", ESolutionType.LongestPalindrome, ExpectedResult = 7)]
        [TestCase("a", ESolutionType.LongestPalindrome, ExpectedResult = 1)]
        [TestCase("ccc", ESolutionType.LongestPalindrome, ExpectedResult = 3)]
        [TestCase("ababababa", ESolutionType.LongestPalindrome, ExpectedResult = 9)]
        [TestCase("abccccdd", ESolutionType.Best, ExpectedResult = 7)]
        [TestCase("a", ESolutionType.Best, ExpectedResult = 1)]
        [TestCase("ccc", ESolutionType.Best, ExpectedResult = 3)]
        [TestCase("ababababa", ESolutionType.Best, ExpectedResult = 9)]
        public int Test(string s, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(s, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}