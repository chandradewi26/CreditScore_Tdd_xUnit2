namespace CreditScore.Tests
{
    public class CompletedPaymentCalculatorTests
    {
        private readonly CompletedPaymentCalculator _calculator;

        public CompletedPaymentCalculatorTests()
        {
            //Arrange
            _calculator = new CompletedPaymentCalculator();
        }

        [Theory(DisplayName = "TODO: 'The completed payment point calculator' should return the correct number of points from the given completed payment count input")]
        [InlineData(-100, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(5, 4)]
        public void TestPointCalculation(int completedPayment, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(completedPayment);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
        }
    }
}
