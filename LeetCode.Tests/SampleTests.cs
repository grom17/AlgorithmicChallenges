namespace LeetCode.Tests
{
    using System.Diagnostics;
    using NUnit.Framework;

    [TestFixture]
    public class SampleTests
    {
        [TestCase(true, true)]
        public void Test(bool value, bool expectedResult)
        {
            var sw = new Stopwatch();

            sw.Start();
            
            // Arrange & Act
            var result = value;

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}