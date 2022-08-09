using AlgorithmicChallenges.Problems.LeetCode.Easy.ValidPalindrome;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class ValidPalindromeTests
    {
        [TestCase("A man, a plan, a canal: Panama", ESolutionType.ReverseAndCompareStrings, ExpectedResult = true)]
        [TestCase("race a car", ESolutionType.ReverseAndCompareStrings, ExpectedResult = false)]
        [TestCase(" ", ESolutionType.ReverseAndCompareStrings, ExpectedResult = true)]
        [TestCase("0P", ESolutionType.ReverseAndCompareStrings, ExpectedResult = false)]
        [TestCase("A man, a plan, a canal: Panama", ESolutionType.Loops, ExpectedResult = true)]
        [TestCase("race a car", ESolutionType.Loops, ExpectedResult = false)]
        [TestCase(" ", ESolutionType.Loops, ExpectedResult = true)]
        [TestCase("0P", ESolutionType.Loops, ExpectedResult = false)]
        public bool Test(string s, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(s, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}