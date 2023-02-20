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
    }
}