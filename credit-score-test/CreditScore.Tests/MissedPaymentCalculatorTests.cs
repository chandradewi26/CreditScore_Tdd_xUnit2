namespace CreditScore.Tests
{
    public class MissedPaymentCalculatorTests
    {
        private readonly MissedPaymentCalculator _calculator;

        public MissedPaymentCalculatorTests()
        {
            //Arrange
            _calculator = new MissedPaymentCalculator();
        }

        [Fact(DisplayName = "When the customer has 0 missed payment count, MissedPaymentCalculator should return 0 point")]
        public void TestPointCalculation_MissedPaymentCount0_Return0()
        {
            //Act
            int points = _calculator.CalculatePoint(0);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "When the customer has 1 missed payment count, MissedPaymentCalculator should return -1 point")]
        public void TestPointCalculation_MissedPaymentCount1_ReturnMin1()
        {
            //Act
            int points = _calculator.CalculatePoint(1);
            //Assert (expected, actual)
            Assert.StrictEqual(-1, points);
        }

        [Fact(DisplayName = "When the customer has 2 missed payment counts, MissedPaymentCalculator should return -3 points")]
        public void TestPointCalculation_MissedPaymentCount2_ReturnMin3()
        {
            //Act
            int points = _calculator.CalculatePoint(2);
            //Assert (expected, actual)
            Assert.StrictEqual(-3, points);
        }

        [Fact(DisplayName = "When the customer has equal to or more than 3 missed payment counts, MissedPaymentCalculator should return -6 points")]
        public void TestPointCalculation_MissedPaymentCountMoreEqualOrMoreThan3_ReturnMin6()
        {
            //Act
            int points = _calculator.CalculatePoint(5);
            //Assert (expected, actual)
            Assert.StrictEqual(-6, points);
        }

        [Fact(DisplayName = "Given negative number of missed payment count, MissedPaymentCalculator should throw exception")]
        public void TestPointCalculation_MissedPaymentNegativeNumber_ShouldThrowException()
        {
            //Act
            Action action = () => _calculator.CalculatePoint(-5);
            //Assert
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        }
        
    }
}
