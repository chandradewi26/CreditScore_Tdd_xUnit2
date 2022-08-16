namespace CreditScore.Tests
{
    public class MissedPaymentCalculatorTests
    {
        private readonly MissedPaymentCalculator _calculator;

        public MissedPaymentCalculatorTests()
        {
            _calculator = new MissedPaymentCalculator();
        }

        [Fact(DisplayName = "When the customer has 0 missed payment count, MissedPaymentCalculator should return 0 point")]
        public void TestPointCalculation_MissedPaymentCount0_Return0()
        {
            TestPointCalculation(0, 0);
        }

        [Fact(DisplayName = "When the customer has 1 missed payment count, MissedPaymentCalculator should return -1 point")]
        public void TestPointCalculation_MissedPaymentCount1_ReturnMin1()
        {
            TestPointCalculation(1, -1);
        }

        [Fact(DisplayName = "When the customer has 2 missed payment counts, MissedPaymentCalculator should return -3 points")]
        public void TestPointCalculation_MissedPaymentCount2_ReturnMin3()
        {
            TestPointCalculation(2, -3);
        }

        [Fact(DisplayName = "When the customer has equal to or more than 3 missed payment counts, MissedPaymentCalculator should return -6 points")]
        public void TestPointCalculation_MissedPaymentCountMoreEqualOrMoreThan3_ReturnMin6()
        {
            TestPointCalculation(5, -6);
        }

        [Fact(DisplayName = "Given negative number of missed payment count, MissedPaymentCalculator should throw exception")]
        public void TestPointCalculation_MissedPaymentNegativeNumber_ShouldThrowException()
        {
            Action action = () => _calculator.CalculatePoint(-5);
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        }

        public void TestPointCalculation(int inputValue, int expectedOutput)
        {
            var points = _calculator.CalculatePoint(inputValue);
            Assert.StrictEqual(expectedOutput, points);
        }
    }
}
