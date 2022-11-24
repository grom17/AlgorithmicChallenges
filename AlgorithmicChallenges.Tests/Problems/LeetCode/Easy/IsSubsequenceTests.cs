using AlgorithmicChallenges.Problems.LeetCode.Easy.IsSubsequence;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;
    
    [TestFixture]
    public class IsSubsequenceTests
    {
        [TestCase("abc", "ahbgdc", ESolutionType.IsSubsequence, ExpectedResult = true)]
        [TestCase("axc", "ahbgdc", ESolutionType.IsSubsequence, ExpectedResult = false)]
        [TestCase("acb", "ahbgdc", ESolutionType.IsSubsequence, ExpectedResult = false)]
        public bool Test(string s, string t, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(s, t, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}