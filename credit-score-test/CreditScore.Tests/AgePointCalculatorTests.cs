namespace CreditScore.Tests
{
    public class AgePointCalculatorTests
    {
        //Arrange
        private readonly AgePointCalculator _calculator;

        public AgePointCalculatorTests()
        {
            //Arrange
            _calculator = new AgePointCalculator();
        }

        [Fact(DisplayName = "The 'AgePointCalculator' should return 0 points from the given age of negative number (-10)")]
        public void TestPointCalculation_InputIs65_ExpectedPoints6()
        {
            //Act
            int points = _calculator.CalculatePoint(-10);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }
        [Fact(DisplayName = "The 'AgePointCalculator' should return 0 points from the given age of younger than 18 years old")]
        public void TestPointCalculation_InputLessThan18_ExpectedPoints0()
        {
            //Act
            int points = _calculator.CalculatePoint(17);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'AgePointCalculator' should return 3 points from the given age range of 18 to 25 years old")]
        public void TestPointCalculation_InputBetween18to25_ExpectedPoints3()
        {
            //Act
            int points = _calculator.CalculatePoint(18);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "The 'AgePointCalculator' should return 4 points from the given age range of 26 to 35 years old")]
        public void TestPointCalculation_InputBetween26to35_ExpectedPoints4()
        {
            //Act
            int points = _calculator.CalculatePoint(26);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }

        [Fact(DisplayName = "The 'AgePointCalculator' should return 5 points from the given age range of 36 to 50 years old")]
        public void TestPointCalculation_InputBetween36to50_ExpectedPoints5()
        {
            //Act
            int points = _calculator.CalculatePoint(36);
            //Assert (expected, actual)
            Assert.StrictEqual(5, points);
        }

        [Fact(DisplayName = "The 'AgePointCalculator' should return 6 points from the given age of more than 51 years old")]
        public void TestPointCalculation_InputIsMoreThan51_ExpectedPoints6()
        {
            //Act
            int points = _calculator.CalculatePoint(51);
            //Assert (expected, actual)
            Assert.StrictEqual(6, points);
        }
    }
}
