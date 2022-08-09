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
