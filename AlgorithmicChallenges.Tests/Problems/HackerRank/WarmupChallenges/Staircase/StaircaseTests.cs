namespace AlgorithmicChallenges.Tests.Problems.HackerRank.WarmupChallenges.Staircase
{
    using AlgorithmicChallenges.Problems.HackerRank.WarmupChallenges.Staircase;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class StaircaseTestsTests
    {
        [TestCase(6, 
            @"     #
    ##
   ###
  ####
 #####
######")]
        [TestCase(7, 
            @"      #
     ##
    ###
   ####
  #####
 ######
#######")]
        public void Test(int n, string expectedResult)
        {
            // Arrange & Act
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(n));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}