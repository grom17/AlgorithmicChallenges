namespace AlgorithmicChallenges.Tests
{
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class SampleTests
    {
        [TestCase(true, true)]
        public void Test(bool value, bool expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => value);

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}