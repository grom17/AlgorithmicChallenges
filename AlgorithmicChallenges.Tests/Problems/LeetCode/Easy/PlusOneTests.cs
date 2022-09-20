using AlgorithmicChallenges.Problems.LeetCode.Easy.PlusOne;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class PlusOneTests
    {
        [TestCase(new[] { 1, 2, 3 }, ESolutionType.PlusOne, ExpectedResult = new[] { 1, 2, 4 })]
        [TestCase(new[] { 9, 9, 9 }, ESolutionType.PlusOne, ExpectedResult = new[] { 1, 0, 0, 0 })]
        public int[] Test(int[] digits, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(digits, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}