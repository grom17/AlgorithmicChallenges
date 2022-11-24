using AlgorithmicChallenges.Problems.LeetCode.Easy.IsomorphicStrings;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;
    
    [TestFixture]
    public class IsomorphicStringsTests
    {
        [TestCase("egg", "add", ESolutionType.IsIsomorphic, ExpectedResult = true)]
        [TestCase("foo", "bar", ESolutionType.IsIsomorphic, ExpectedResult = false)]
        [TestCase("paper", "title", ESolutionType.IsIsomorphic, ExpectedResult = true)]
        [TestCase("badc", "baba", ESolutionType.IsIsomorphic, ExpectedResult = false)]
        public bool Test(string s, string t, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(s, t, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}