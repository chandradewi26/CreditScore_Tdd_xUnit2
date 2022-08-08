using CreditScore;

namespace CreditScore.Tests
{
    public class BureauScorePointCalculatorTests
    {
        private readonly BureauScoreCalculator _calculator;

        public BureauScorePointCalculatorTests()
        {
            _calculator = new BureauScoreCalculator();
        }

        [Theory]
        [InlineData(-100, 0)]
        [InlineData(100, 0)]
        [InlineData(500, 1)]
        [InlineData(750, 2)]
        [InlineData(900, 3)]
        [InlineData(1300, 0)]
        public void CalculatePoint_GivenBureauScore_ShouldReturnCorrectPoins(int bureauScore, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(bureauScore);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
            //$"\nAge : {age}\nPoints should be equal"
        }
    }
}
