namespace AlgorithmicChallenges.Tests
{
    using AlgorithmicChallenges.Problems.Sample;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class SampleTests
    {
        [TestCase(42, ESolutionType.Solution1, ExpectedResult = 42)]
        public int Test(int input, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(input, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}