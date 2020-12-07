namespace LeetCode.Tests.Problems.AdventOfCode.Day4
{
    using System.Diagnostics;
    using LeetCode.Problems.AdventOfCode.Day4;
    using NUnit.Framework;

    [TestFixture]
    public class Part1Tests
    {
        [Test]
        public void TestWithSample()
        {
            // Arrange
            var input = @"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd
byr:1937 iyr:2017 cid:147 hgt:183cm

iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884
hcl:#cfa07d byr:1929

hcl:#ae17e1 iyr:2013
eyr:2024
ecl:brn pid:760753108 byr:1931
hgt:179cm

hcl:#cfa07d eyr:2025 pid:166559648
iyr:2011 ecl:brn hgt:59in";
            
            const int expectedResult = 2;
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = Part1Solution.Run(input);

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");
            TestContext.Out.WriteLine($"Result={result}");
            
            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [Test]
        public void TestWithInput()
        {
            // Arrange
            var input = TestData.GetDay4Input();
            
            var sw = new Stopwatch();
            sw.Start();

            // Act
            var result = Part1Solution.Run(input);

            sw.Stop();
            
            TestContext.Out.WriteLine($"Elapsed={sw.ElapsedMilliseconds}");
            TestContext.Out.WriteLine($"Result={result}");
        }
    }
}