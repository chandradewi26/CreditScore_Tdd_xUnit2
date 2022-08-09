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

        [Fact(DisplayName = "The 'completed payment point calculator' should return 0 points from the given completed payment count of 0")]
        public void TestPointCalculation_InputIs0_ExpectedIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(0);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'completed payment point calculator' should return 2 points from the given completed payment count of 1")]
        public void TestPointCalculation_InputIs1_ExpectedIs2()
        {
            //Act
            int points = _calculator.CalculatePoint(1);
            //Assert (expected, actual)
            Assert.StrictEqual(2, points);
        }

        [Fact(DisplayName = "The 'completed payment point calculator' should return 3 points from the given completed payment count of 2")]
        public void TestPointCalculation_InputIs2_ExpectedIs3()
        {
            //Act
            int points = _calculator.CalculatePoint(2);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "The 'completed payment point calculator' should return 4 points from the given completed payment count of 3")]
        public void TestPointCalculation_InputIs3_ExpectedIs4()
        {
            //Act
            int points = _calculator.CalculatePoint(3);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }
    }
}
