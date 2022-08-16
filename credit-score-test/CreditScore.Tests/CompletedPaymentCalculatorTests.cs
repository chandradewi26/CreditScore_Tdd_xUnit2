namespace CreditScore.Tests
{
    public class CompletedPaymentCalculatorTests
    {
        private readonly CompletedPaymentCalculator _calculator;

        public CompletedPaymentCalculatorTests()
        {
            _calculator = new CompletedPaymentCalculator();
        }

        [Fact(DisplayName = "When the customer has 0 completed payment count, CompletedPaymentCalculator should return 0 point")]
        public void TestPointCalculation_CompPaymentCount0_Return0()
        {
            TestPointCalculation(0, 0);
        }

        [Fact(DisplayName = "When the customer has 1 completed payment count, CompletedPaymentCalculator should return 2 points")]
        public void TestPointCalculation_CompPaymentCount1_Return2()
        {
            TestPointCalculation(1, 2);
        }

        [Fact(DisplayName = "When the customer has 2 completed payment count, CompletedPaymentCalculator should return 3 points")]
        public void TestPointCalculation_CompPaymentCount2_Return3()
        {
            TestPointCalculation(2, 3);
        }

        [Fact(DisplayName = "When the customer has equal to or more than 3 completed payment count, CompletedPaymentCalculator should return 4 points")]
        public void TestPointCalculation_CompPaymentCountEqualOrMoreThan3_Return4()
        {
            TestPointCalculation(3, 4);
        }

        [Fact(DisplayName = "Given negative number of completed payment count, CompletedPaymentCalculator should throw exception")]
        public void TestPointCalculation_CompletedPaymentNegativeNumber_ShouldThrowException()
        {
            Action action = () => _calculator.CalculatePoint(-2);
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }

        public void TestPointCalculation(int inputValue, int expectedOutput)
        {
            var points = _calculator.CalculatePoint(inputValue);
            Assert.StrictEqual(expectedOutput, points);
        }
    }
}
