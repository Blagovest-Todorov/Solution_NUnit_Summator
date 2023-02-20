using FluentAssertions;

namespace Summator.Tests
{
    [TestFixture]
    public class Tests
    {        
        public void Setup()
        {
        }

        [Test]
        public void Sum_TwoPositiveNumbers_IsSuccessful()
        {
            decimal expected = 12;
            decimal result = Summator.Sum(new decimal[] {7, 5});
            Assert.AreEqual(expected, result, "Test_Message");
        }

        [Test]
        public void Sum_OnePositiveNumber_IsSuccessful() 
        {
            // now lets use fluent asserions Api, betterWay
            decimal expected = 10;
            decimal result = Summator.Sum(new decimal[] { 10 });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_TwoNegativeNumbers_IsSuccessful()
        {
            decimal expected = -10;
            decimal result = Summator.Sum(new decimal[] { -6, -4 });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_OneNegativeNumber_IsSuccessful()
        {
            decimal expected = -100;
            decimal result = Summator.Sum(new decimal[] { -100 });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_EmptyArray_IsSuccessful()
        {
            decimal expected = 0;
            decimal result = Summator.Sum(new decimal[] { });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_Nulls_IsSuccessful()
        {
            decimal expected = 0;
            decimal result = Summator.Sum(new decimal[] {0, 0, 0, 0 });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_Negative_with_PositiveNumbers_IsSuccessful()
        {
            decimal expected = -15;
            decimal result = Summator.Sum(new decimal[] { 0, 10, -5, -20 });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_ExtremelyBigPositiveNumbers_IsSuccessful()
        {
            decimal expected = 3149000000;
            decimal result = Summator.Sum(new decimal[] { 1000000000, 2149000000 });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_ExtremelyBigNegativeNumbers_IsSuccessful()
        {
            decimal expected = -3149000000;
            decimal result = Summator.Sum(new decimal[] { -1000000000, -2149000000 });
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_ExtremelyBigNegative_And_PositiveNumbers_IsSuccessful()
        {
            decimal expected = 1149000000;
            decimal result = Summator.Sum(new decimal[] { -1000000000, 2149000000 });
            result.Should().Be(expected);
        }

        [Test]
        public void CheckAverage_IsSuccessful() 
        {
            decimal expectedAverageNum = 5.3333333333333333333333333333M;
            var actualAverageNum = Summator.Average(new decimal[] {5, 10, 1});
            actualAverageNum.Should().Be(expectedAverageNum);
            actualAverageNum.Should().BeGreaterThan(decimal.MinValue);
            actualAverageNum.Should().BeInRange(0, 100);
        }
    }
}