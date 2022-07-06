namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using AlgorithmicChallenges.Problems.LeetCode.Easy.JewelsAndStones;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class JewelsAndStonesTests
    {
        [TestCase("aA", "aAAbbbb", ESolutionType.LinqWithGroupBy, ExpectedResult = 3)]
        [TestCase("z", "ZZ", ESolutionType.LinqWithGroupBy, ExpectedResult = 0)]
        [TestCase("aA", "aAAbbbb", ESolutionType.Linq, ExpectedResult = 3)]
        [TestCase("z", "ZZ", ESolutionType.Linq, ExpectedResult = 0)]
        [TestCase("aA", "aAAbbbb", ESolutionType.Loops, ExpectedResult = 3)]
        [TestCase("z", "ZZ", ESolutionType.Loops, ExpectedResult = 0)]
        public int Test(string jewels, string stones, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(jewels, stones, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}