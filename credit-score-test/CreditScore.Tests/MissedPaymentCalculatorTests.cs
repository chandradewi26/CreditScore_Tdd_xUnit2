namespace CreditScore.Tests
{
    public class MissedPaymentCalculatorTests
    {
        private readonly MissedPaymentCalculator _calculator;

        public MissedPaymentCalculatorTests()
        {
            //Arrange
            _calculator = new MissedPaymentCalculator();
        }

        [Theory(DisplayName = "TODO: 'The missed payment point calculator' should return the correct number of points from the given missed payment count input")]
        [InlineData(-100, 0)]
        [InlineData(0, 0)]
        [InlineData(1, -1)]
        [InlineData(2, -3)]
        [InlineData(3, -6)]
        [InlineData(5, -6)]
        public void TestPointCalculation(int missedPayment, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(missedPayment);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
        }
    }
}
