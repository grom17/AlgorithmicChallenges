namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using AlgorithmicChallenges.Problems.LeetCode.Easy.DefangingIpAddress;
    using NUnit.Framework;

    [TestFixture]
    public class DefangingIpAddressTests
    {
        [TestCase("1.1.1.1", ExpectedResult = "1[.]1[.]1[.]1")]
        [TestCase("255.100.50.0", ExpectedResult = "255[.]100[.]50[.]0")]
        public string Test(string address)
        {
            var result= Solution.Run(address);

            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}