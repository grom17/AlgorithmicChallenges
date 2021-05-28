namespace AlgorithmicChallenges.Tests.Problems.HackerRank.WarmupChallenges.RepeatedString
{
    using AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.RepeatedString;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class RepeatedStringTests
    {
        [TestCase("abcac", 10, 4)]
        [TestCase("aba", 10, 7)]
        [TestCase("a", 1000000000000, 1000000000000)]
        [TestCase("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400, 51574523448)]
        public void Test(string s, long n, long expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(s, n));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}