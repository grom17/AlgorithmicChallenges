namespace AlgorithmicChallenges.Tests.Problems.LeetCode.Easy
{
    using AlgorithmicChallenges.Problems.LeetCode.Easy.ContainsDuplicate;
    using NUnit.Framework;
    using static Helpers.StopwatchHelper;

    [TestFixture]
    public class ContainsDuplicateTests
    {
        [TestCase(new[] { 1, 2, 3, 1 }, ESolutionType.Linq, ExpectedResult = true)]
        [TestCase(new[] { 1, 2, 3, 4 }, ESolutionType.Linq, ExpectedResult = false)]
        [TestCase(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, ESolutionType.Linq, ExpectedResult = true)]
        [TestCase(new[] { 1, 2, 3, 1 }, ESolutionType.ForeachWithHashSet, ExpectedResult = true)]
        [TestCase(new[] { 1, 2, 3, 4 }, ESolutionType.ForeachWithHashSet, ExpectedResult = false)]
        [TestCase(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, ESolutionType.ForeachWithHashSet, ExpectedResult = true)]
        [TestCase(new[] { 1, 2, 3, 1 }, ESolutionType.ArrayToHashSet, ExpectedResult = true)]
        [TestCase(new[] { 1, 2, 3, 4 }, ESolutionType.ArrayToHashSet, ExpectedResult = false)]
        [TestCase(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, ESolutionType.ArrayToHashSet, ExpectedResult = true)]
        public bool Test(int[] nums, ESolutionType solutionType)
        {
            var (result, timeElapsed) = RunWithStopwatch(() => Solution.Run(nums, solutionType));

            TestContext.Out.WriteLine($"Elapsed={timeElapsed}");
            TestContext.Out.WriteLine($"Result={result}");

            return result;
        }
    }
}