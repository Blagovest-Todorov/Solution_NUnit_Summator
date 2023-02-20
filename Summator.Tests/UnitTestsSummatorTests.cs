using FluentAssertions;

namespace Summator.Tests
{
    [TestFixture]
    public class Tests
    {
        private Summator summator;

        [SetUp]
        public void Setup()
        {
            this.summator = new Summator(); 
            Console.WriteLine("Test started " + DateTime.Now);
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine(" ALL ALL ALL Test started once " + DateTime.Now);
        }

        [TearDown]
        public void TearDown() 
        {
            Console.WriteLine("Test ended " + DateTime.Now);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("ALL ALL ALL Test Test ended " + DateTime.Now);
        }

        [Test]
        [Category("Critical")]  // Category appears if we select in TestExplorer Groyp By -> Traits
        public void Sum_TwoPositiveNumbers_IsSuccessful()
        {
            // Arrange
            decimal expected = 12;
            var values = new decimal[] { 7, 5 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            Assert.AreEqual(expected, result, "Test_Message");
        }

        [Test]
        [Category("Not Critical")]
        public void Sum_OnePositiveNumber_IsSuccessful() 
        {
            // Arrange
            // now lets use fluent asserions Api, betterWay
            decimal expected = 10;
            var values = new decimal[] { 10 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_TwoNegativeNumbers_IsSuccessful()
        {
            // Arrange
            decimal expected = -10;
            var values = new decimal[] { -6, -4 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_OneNegativeNumber_IsSuccessful()
        {
            // Arrange
            decimal expected = -100;
            var values = new decimal[] { -100 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_EmptyArray_IsSuccessful()
        {
            // Arrange
            decimal expected = 0;
            var values = new decimal[] { };    
            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_Nulls_IsSuccessful()
        {
            // Arrange
            decimal expected = 0;
            var values = new decimal[] { 0, 0, 0, 0 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_Negative_with_PositiveNumbers_IsSuccessful()
        {
            // Arrange
            decimal expected = -15;
            var values = new decimal[] { 0, 10, -5, -20 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_ExtremelyBigPositiveNumbers_IsSuccessful()
        {
            // Arrange
            decimal expected = 3149000000;
            var values = new decimal[] { 1000000000, 2149000000 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_ExtremelyBigNegativeNumbers_IsSuccessful()
        {
            // Arrange
            decimal expected = -3149000000;
            var values = new decimal[] { -1000000000, -2149000000 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void Sum_ExtremelyBigNegative_And_PositiveNumbers_IsSuccessful()
        {
            // Arrange
            decimal expected = 1149000000;
            var values = new decimal[] { -1000000000, 2149000000 };

            // Act
            decimal result = summator.Sum(values);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void CheckAverage_IsSuccessful() 
        {
            // Arrange
            decimal expectedAverageNum = 5.3333333333333333333333333333M;
            var values = new decimal[] { 5, 10, 1 };
            string date = "7/11/2021";

            // Act  this is static mehtod here so we call it over tha class name directly (not over instance Object)
            var actualAverageNum = Summator.Average(values);

            // Assert
            // Fluent Assertions Library
            actualAverageNum.Should().Be(expectedAverageNum);
            actualAverageNum.Should().BeGreaterThan(decimal.MinValue);
            actualAverageNum.Should().BeInRange(0, 100);
            actualAverageNum.Should().BeInRange(0, int.MaxValue);
            // Nunit Assertion
            Assert.That("Qs are awesome", Does.Contain("awesome"), "Free Message Test");
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));
            Assert.That(() => "abv"[10], Throws.InstanceOf<IndexOutOfRangeException>());
            Assert.That(() => "abv"[10], Throws.TypeOf<IndexOutOfRangeException>());
            Assert.That(Enumerable.Range(1, 100), Has.Member(10));
            Assert.That(new int[] {10, 20, 30, 45, 59}, Is.All.InRange(10, 59));

            string actualFilePath = @"C:\\Users\\Bla\\source\\repos\\B.txt";
            string existingDirectoryPath = @"C:\\Users\\Bla\\source\\repos";
            Assert.That(actualFilePath, Does.Exist);
            DirectoryAssert.Exists(existingDirectoryPath);

        }
    }
}