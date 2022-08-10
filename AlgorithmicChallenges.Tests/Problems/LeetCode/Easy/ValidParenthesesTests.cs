using AlgorithmicChallenges.Problems.LeetCode.Easy.ValidParentheses;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class ValidParenthesesTests
    {
        [TestCase("()", ESolutionType.Stack, ExpectedResult = true)]
        [TestCase("()[]{}", ESolutionType.Stack, ExpectedResult = true)]
        [TestCase("(]", ESolutionType.Stack, ExpectedResult = false)]
        [TestCase("])", ESolutionType.Stack, ExpectedResult = false)]
        [TestCase("(){}[](", ESolutionType.Stack, ExpectedResult = false)]
        public bool Test(string s, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(s, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}