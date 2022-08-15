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

        [Fact(DisplayName = "When the customer has 0 completed payment count, CompletedPaymentCalculator should return 0 point")]
        public void TestPointCalculation_CompPaymentCount0_Return0()
        {
            //Act
            int points = _calculator.CalculatePoint(0);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "When the customer has 1 completed payment count, CompletedPaymentCalculator should return 2 points")]
        public void TestPointCalculation_CompPaymentCount1_Return2()
        {
            //Act
            int points = _calculator.CalculatePoint(1);
            //Assert (expected, actual)
            Assert.StrictEqual(2, points);
        }

        [Fact(DisplayName = "When the customer has 2 completed payment count, CompletedPaymentCalculator should return 3 points")]
        public void TestPointCalculation_CompPaymentCount2_Return3()
        {
            //Act
            int points = _calculator.CalculatePoint(2);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "When the customer has equal to or more than 3 completed payment count, CompletedPaymentCalculator should return 4 points")]
        public void TestPointCalculation_CompPaymentCountEqualOrMoreThan3_Return4()
        {
            //Act
            int points = _calculator.CalculatePoint(3);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }

        [Fact(DisplayName = "Given negative number of completed payment count, CompletedPaymentCalculator should throw exception")]
        public void TestPointCalculation_CompletedPaymentNegativeNumber_ShouldThrowException()
        {
            //Act
            Action action = () => _calculator.CalculatePoint(-2);
            //Assert
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        }
    }
}
