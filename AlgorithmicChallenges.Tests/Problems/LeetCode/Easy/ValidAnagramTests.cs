using AlgorithmicChallenges.Problems.LeetCode.Easy.ValidAnagram;
using NUnit.Framework;

namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class SampleTests
    {
        [TestCase("anagram", "nagaram", ESolutionType.SortCharsAndCompareStrings, ExpectedResult = true)]
        [TestCase("rat", "car", ESolutionType.SortCharsAndCompareStrings, ExpectedResult = false)]
        [TestCase("anagram", "nagaram", ESolutionType.SortCharsAndCompareSequences, ExpectedResult = true)]
        [TestCase("rat", "car", ESolutionType.SortCharsAndCompareSequences, ExpectedResult = false)]
        public bool Test(string s, string t, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(s, t, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}