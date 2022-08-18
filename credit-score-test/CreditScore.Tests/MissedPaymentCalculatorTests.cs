namespace CreditScore.Tests
{
    public class MissedPaymentCalculatorTests
    {
        private readonly MissedPaymentCalculator _calculator;

        public MissedPaymentCalculatorTests()
        {
            _calculator = new MissedPaymentCalculator();
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
            var points = _calculator.CalculatePoint(inputValue);
            Assert.StrictEqual(expectedOutput, points);
        }

        [Fact(DisplayName = "Given negative number of missed payment count, MissedPaymentCalculator should return 0 point")]
        public void TestPointCalculation_MissedPaymentLessThan0_ShouldReturn0()
        {
            var points = _calculator.CalculatePoint(-10);
            Assert.StrictEqual(0, points);
        }
    }
}
