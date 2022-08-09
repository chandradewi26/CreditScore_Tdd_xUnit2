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

        [Fact(DisplayName = "The 'missed payment point calculator' should return 0 points from the given missed payment count of 0")]
        public void TestPointCalculation_InputIs0_ExpectedIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(0);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'missed payment point calculator' should return -1 points from the given missed payment count of 1")]
        public void TestPointCalculation_InputIs1_ExpectedIsMinus1()
        {
            //Act
            int points = _calculator.CalculatePoint(1);
            //Assert (expected, actual)
            Assert.StrictEqual(-1, points);
        }

        [Fact(DisplayName = "The 'missed payment point calculator' should return -3 points from the given missed payment count of 2")]
        public void TestPointCalculation_InputIs2_ExpectedIsMinus3()
        {
            //Act
            int points = _calculator.CalculatePoint(2);
            //Assert (expected, actual)
            Assert.StrictEqual(-3, points);
        }

        [Fact(DisplayName = "The 'missed payment point calculator' should return -6 points from the given missed payment count of 3")]
        public void TestPointCalculation_InputIs3_ExpectedIsMinus6()
        {
            //Act
            int points = _calculator.CalculatePoint(3);
            //Assert (expected, actual)
            Assert.StrictEqual(-6, points);
        }

        [Fact(DisplayName = "The 'missed payment point calculator' should return -6 points from the given missed payment count of 4")]
        public void TestPointCalculation_InputIs4_ExpectedIsMinus6()
        {
            //Act
            int points = _calculator.CalculatePoint(4);
            //Assert (expected, actual)
            Assert.StrictEqual(-6, points);
        }
    }
}
