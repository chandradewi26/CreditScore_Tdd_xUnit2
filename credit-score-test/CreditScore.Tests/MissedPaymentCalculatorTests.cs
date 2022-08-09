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

        [Fact(DisplayName = "The 'MissedPaymentCalculator' should return 0 points from the given missed payment count of negative numbers")]
        public void TestPointCalculation_MissedPaymentCountIsNegativeNumber10_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(-10);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }
        
        [Fact(DisplayName = "The 'MissedPaymentCalculator' should return 0 points from the given missed payment count of 0")]
        public void TestPointCalculation_MissedPaymentCountIs0_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(0);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'MissedPaymentCalculator' should return -1 points from the given missed payment count of 1")]
        public void TestPointCalculation_MissedPaymentCountIs1_ExpectedPointIsMinus1()
        {
            //Act
            int points = _calculator.CalculatePoint(1);
            //Assert (expected, actual)
            Assert.StrictEqual(-1, points);
        }

        [Fact(DisplayName = "The 'MissedPaymentCalculator' should return -3 points from the given missed payment count of 2")]
        public void TestPointCalculation_MissedPaymentCountIs2_ExpectedPointIsMinus3()
        {
            //Act
            int points = _calculator.CalculatePoint(2);
            //Assert (expected, actual)
            Assert.StrictEqual(-3, points);
        }

        [Fact(DisplayName = "The 'MissedPaymentCalculator' should return -6 points from the given missed payment count of 3")]
        public void TestPointCalculation_MissedPaymentCountIs3_ExpectedPointIsMinus6()
        {
            //Act
            int points = _calculator.CalculatePoint(3);
            //Assert (expected, actual)
            Assert.StrictEqual(-6, points);
        }

        [Fact(DisplayName = "The 'MissedPaymentCalculator' should return -6 points from the given missed payment count of more than 3")]
        public void TestPointCalculation_MissedPaymentCountIsMoreThan3_ExpectedPointIsMinus6()
        {
            //Act
            int points = _calculator.CalculatePoint(5);
            //Assert (expected, actual)
            Assert.StrictEqual(-6, points);
        }
    }
}
