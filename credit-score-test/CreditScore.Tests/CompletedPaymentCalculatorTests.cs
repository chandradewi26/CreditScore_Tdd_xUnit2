using CreditScore;

namespace CreditScore.Tests
{
    public class CompletedPaymentPointCalculatorTests
    {
        private readonly CompletedPaymentCalculator _calculator;

        public CompletedPaymentPointCalculatorTests()
        {
            _calculator = new CompletedPaymentCalculator();
        }

        [Theory]
        [InlineData(-100, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(5, 4)]
        public void CalculatePoint_GivenCompletedPaymentCount_ShouldReturnCorrectPoins(int completedPayment, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(completedPayment);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
            //$"\nAge : {age}\nPoints should be equal"
        }
    }
}
