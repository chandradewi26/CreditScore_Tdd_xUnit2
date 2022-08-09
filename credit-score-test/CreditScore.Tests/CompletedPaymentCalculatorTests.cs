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

        [Fact(DisplayName = "The 'CompletedPaymentCalculator' should return 0 points from the given completed payment count of negative numbers")]
        public void TestPointCalculation_CompletedPaymentCountIsNegativeNumber10_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(-10);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'CompletedPaymentCalculator' should return 0 points from the given completed payment count of 0")]
        public void TestPointCalculation_CompletedPaymentCountIs0_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(0);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }
        [Fact(DisplayName = "The 'CompletedPaymentCalculator' should return 2 points from the given completed payment count of 1")]
        public void TestPointCalculation_CompletedPaymentCountIs1_ExpectedPointIs2()
        {
            //Act
            int points = _calculator.CalculatePoint(1);
            //Assert (expected, actual)
            Assert.StrictEqual(2, points);
        }
        [Fact(DisplayName = "The 'CompletedPaymentCalculator' should return 3 points from the given completed payment count of 2")]
        public void TestPointCalculation_CompletedPaymentCountIs2_ExpectedPointIs3()
        {
            //Act
            int points = _calculator.CalculatePoint(2);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }
        [Fact(DisplayName = "The 'CompletedPaymentCalculator' should return 4 points from the given completed payment count of 3")]
        public void TestPointCalculation_CompletedPaymentCountIs3_ExpectedPointIs4()
        {
            //Act
            int points = _calculator.CalculatePoint(3);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }
        [Fact(DisplayName = "The 'CompletedPaymentCalculator' should return 4 points from the given completed payment count of more than 3")]
        public void TestPointCalculation_CompletedPaymentCountIs5_ExpectedPointIs4()
        {
            //Act
            int points = _calculator.CalculatePoint(5);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }
    }
}
