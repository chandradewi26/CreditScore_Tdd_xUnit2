using CreditScore;

namespace CreditScore.Tests
{
    public class MissedPaymentPointCalculatorTests
    {
        private readonly MissedPaymentCalculator _calculator;

        public MissedPaymentPointCalculatorTests()
        {
            _calculator = new MissedPaymentCalculator();
        }

        [Theory]
        [InlineData(-100, 0)]
        [InlineData(0, 0)]
        [InlineData(1, -1)]
        [InlineData(2, -3)]
        [InlineData(3, -6)]
        [InlineData(5, -6)]
        public void CalculatePoint_GivenMissedPaymentCount_ShouldReturnCorrectPoins(int missedPayment, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(missedPayment);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
            //$"\nAge : {age}\nPoints should be equal"
        }
    }
}
