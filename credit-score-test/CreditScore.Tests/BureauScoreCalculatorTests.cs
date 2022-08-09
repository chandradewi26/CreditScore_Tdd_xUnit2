namespace CreditScore.Tests
{
    public class BureauScoreCalculatorTests
    {
        private readonly BureauScoreCalculator _calculator;

        public BureauScoreCalculatorTests()
        {
            //Arrange
            _calculator = new BureauScoreCalculator();
        }

        [Fact]
        public void TestPointCalculation_BScoreIs200_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(200);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact]
        public void TestPointCalculation_BScoreIs780_ExpectedPointIs2()
        {
            //Act
            int points = _calculator.CalculatePoint(780);
            //Assert (expected, actual)
            Assert.StrictEqual(2, points);
        }


        [Theory(DisplayName = "TODO: The 'bureau score point calculator' should return the correct number of points from the given bureau score input")]
        [InlineData(-100, 0)]
        [InlineData(100, 0)]
        [InlineData(500, 1)]
        [InlineData(750, 2)]
        [InlineData(900, 3)]
        [InlineData(1300, 0)]
        public void TestPointCalculation(int bureauScore, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(bureauScore);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
        }
    }
}
