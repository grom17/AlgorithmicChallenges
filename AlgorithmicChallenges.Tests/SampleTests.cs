namespace AlgorithmicChallenges.Tests
{
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class SampleTests
    {
        [TestCase(true, ExpectedResult = true)]
        public bool Test(bool value)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => value);

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}