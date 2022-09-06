namespace CreditScore.Tests
{
    public class CompletedPaymentCalculatorTests
    {
        private readonly CompletedPaymentCalculator _calculator;

        public CompletedPaymentCalculatorTests()
        {
            _calculator = new CompletedPaymentCalculator();
        }

        private Customer CreateDummyCustomer(int inputValue)
        {
            return new Customer(0, 0, inputValue, 0);
        }

        [Theory(DisplayName = "Given customer's completed payment count, CompletedPaymentCalculator should calculate the correct point")]
        [InlineData(-10, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 4)]
        public void TestPointCalculation_GivenCompletedPaymentCount_ReturnCorrectPoint(int inputValue, int expectedOutput)
        {
            var customer = CreateDummyCustomer(inputValue);
            var points = _calculator.CalculatePoint(customer);
            Assert.StrictEqual(expectedOutput, points);
        }

        [Fact(DisplayName = "Given negative number of completed payment count, CompletedPaymentCalculator should return 0 point")]
        public void TestPointCalculation_CompletedPaymentNegativeNumber_ShouldReturn0()
        {
            var ineligibleCustomer = CreateDummyCustomer(-2);
            var points = _calculator.CalculatePoint(ineligibleCustomer);
            Assert.StrictEqual(0, points);
        }
    }
}
