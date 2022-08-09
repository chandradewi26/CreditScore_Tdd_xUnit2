namespace CreditScore.Tests
{
    public class AgePointCalculatorTests
    {
        private readonly AgePointCalculator _calculator;

        public AgePointCalculatorTests()
        {
            //Arrange
            _calculator = new AgePointCalculator();
        }

        [Fact]
        public void TestPointCalculation_AgeIs15_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(15);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact]
        public void TestPointCalculation_AgeIs20_ExpectedPointIs3()
        {
            //Act
            int points = _calculator.CalculatePoint(20);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Theory(DisplayName = "TODO: The 'age point calculator' should return the correct number of points from the given age input")]
        [InlineData(-100,0)]
        [InlineData(15, 0)]
        [InlineData(20, 3)]
        [InlineData(26, 4)]
        [InlineData(39, 5)]
        [InlineData(55, 6)]
        public void TestPointCalculation(int age, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(age);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
        }
    }
}
