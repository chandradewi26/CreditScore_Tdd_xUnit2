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
            var points = _calculator.CalculatePoint(0);
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "When the customer has 1 completed payment count, CompletedPaymentCalculator should return 2 points")]
        public void TestPointCalculation_CompPaymentCount1_Return2()
        {
            var points = _calculator.CalculatePoint(1);
            Assert.StrictEqual(2, points);
        }

        [Fact(DisplayName = "When the customer has 2 completed payment count, CompletedPaymentCalculator should return 3 points")]
        public void TestPointCalculation_CompPaymentCount2_Return3()
        {
            var points = _calculator.CalculatePoint(2);
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "When the customer has equal to or more than 3 completed payment count, CompletedPaymentCalculator should return 4 points")]
        public void TestPointCalculation_CompPaymentCountEqualOrMoreThan3_Return4()
        {
            var points = _calculator.CalculatePoint(3);
            Assert.StrictEqual(4, points);
        }

        [Fact(DisplayName = "Given negative number of completed payment count, CompletedPaymentCalculator should throw exception")]
        public void TestPointCalculation_CompletedPaymentNegativeNumber_ShouldThrowException()
        {
            Action action = () => _calculator.CalculatePoint(-2);
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }
    }
}
