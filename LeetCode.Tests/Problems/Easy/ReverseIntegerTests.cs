namespace LeetCode.Tests.Problems.Easy
{
    using LeetCode.Problems.Easy.ReverseInteger;
    using NUnit.Framework;

    [TestFixture]
    public class ReverseIntegerTests
    {
        [TestCase(123, 321, ESolutionType.List)]
        [TestCase(-123, -321, ESolutionType.List)]
        [TestCase(120, 21, ESolutionType.List)]
        [TestCase(1, 1, ESolutionType.List)]
        [TestCase(-1, -1, ESolutionType.List)]
        [TestCase(10, 1, ESolutionType.List)]
        [TestCase(100, 1, ESolutionType.List)]
        [TestCase(1534236469, 0, ESolutionType.List)]
        [TestCase(-1563847412, 0, ESolutionType.List)]
        [TestCase(int.MinValue, 0, ESolutionType.List)]
        [TestCase(int.MaxValue, 0, ESolutionType.List)]
        [TestCase(123, 321, ESolutionType.WithoutList)]
        [TestCase(-123, -321, ESolutionType.WithoutList)]
        [TestCase(120, 21, ESolutionType.WithoutList)]
        [TestCase(1, 1, ESolutionType.WithoutList)]
        [TestCase(10, 1, ESolutionType.WithoutList)]
        [TestCase(100, 1, ESolutionType.WithoutList)]
        [TestCase(-1, -1, ESolutionType.WithoutList)]
        [TestCase(1534236469, 0, ESolutionType.WithoutList)]
        [TestCase(-1563847412, 0, ESolutionType.WithoutList)]
        [TestCase(int.MinValue, 0, ESolutionType.WithoutList)]
        [TestCase(int.MaxValue, 0, ESolutionType.WithoutList)]
        [TestCase(123, 321, ESolutionType.Best)]
        [TestCase(-123, -321, ESolutionType.Best)]
        [TestCase(120, 21, ESolutionType.Best)]
        [TestCase(1, 1, ESolutionType.Best)]
        [TestCase(-1, -1, ESolutionType.Best)]
        [TestCase(10, 1, ESolutionType.Best)]
        [TestCase(100, 1, ESolutionType.Best)]
        [TestCase(1534236469, 0, ESolutionType.Best)]
        [TestCase(-1563847412, 0, ESolutionType.Best)]
        [TestCase(int.MinValue, 0, ESolutionType.Best)]
        [TestCase(int.MaxValue, 0, ESolutionType.Best)]
        [TestCase(123, 321, ESolutionType.MyBest)]
        [TestCase(-123, -321, ESolutionType.MyBest)]
        [TestCase(120, 21, ESolutionType.MyBest)]
        [TestCase(1, 1, ESolutionType.MyBest)]
        [TestCase(-1, -1, ESolutionType.MyBest)]
        [TestCase(10, 1, ESolutionType.MyBest)]
        [TestCase(100, 1, ESolutionType.MyBest)]
        [TestCase(1534236469, 0, ESolutionType.MyBest)]
        [TestCase(-1563847412, 0, ESolutionType.MyBest)]
        [TestCase(int.MinValue, 0, ESolutionType.MyBest)]
        [TestCase(int.MaxValue, 0, ESolutionType.MyBest)]
        public void Test(int input, int expectedResult, ESolutionType solutionType)
        {
            // Arrange & Act
            var result = Solution.Run(input, solutionType);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}