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

        [Fact]
        public void TestPointCalculation_CompletedPaymentIs2_ExpectedPointIs3()
        {
            //Act
            int points = _calculator.CalculatePoint(2);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact]
        public void TestPointCalculation_CompletedPaymentIs3_ExpectedPointIs4()
        {
            //Act
            int points = _calculator.CalculatePoint(3);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }

        [Theory(DisplayName = "TODO: The 'completed payment point calculator' should return the correct number of points from the given completed payment count input")]
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
