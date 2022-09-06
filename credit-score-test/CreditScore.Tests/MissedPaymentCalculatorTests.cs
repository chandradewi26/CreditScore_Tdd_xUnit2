namespace CreditScore.Tests
{
    public class MissedPaymentCalculatorTests
    {
        private readonly MissedPaymentCalculator _calculator;

        public MissedPaymentCalculatorTests()
        {
            _calculator = new MissedPaymentCalculator();
        }

        private Customer CreateDummyCustomer(int inputValue)
        {
            return new Customer(0, inputValue, 0, 0);
        }

        [Theory(DisplayName = "Given customer's missed payment count, MissdPaymentCalculator should calculate the correct point")]
        [InlineData(-10, 0)]
        [InlineData(0, 0)]
        [InlineData(1, -1)]
        [InlineData(2, -3)]
        [InlineData(3, -6)]
        [InlineData(4, -6)]
        public void TestPointCalculation_GivenMissedPaymentCount_ReturnCorrectPoint(int inputValue, int expectedOutput)
        {
            var customer = CreateDummyCustomer(inputValue);
            var points = _calculator.CalculatePoint(customer);
            Assert.StrictEqual(expectedOutput, points);
        }

        [Fact(DisplayName = "Given negative number of missed payment count, MissedPaymentCalculator should return 0 point")]
        public void TestPointCalculation_MissedPaymentLessThan0_ShouldReturn0()
        {
            var ineligibleCustomer = CreateDummyCustomer(-10);
            var points = _calculator.CalculatePoint(ineligibleCustomer);
            Assert.StrictEqual(0, points);
        }
    }
}
