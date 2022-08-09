namespace CreditScore.Tests
{
    public class AgePointCalculatorTests
    {
        private readonly AgePointCalculator _calculator;

        public AgePointCalculatorTests()
        {
            //Arrange
            _calculator = new AgePointCalculator();
        }

        [Fact(DisplayName = "The 'age point calculator' should return 0 points from the given age of 15")]
        public void TestPointCalculation_InputIs15_ExpectedIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(15);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'age point calculator' should return 3 points from the given age of 25")]
        public void TestPointCalculation_InputIs25_ExpectedIs3()
        {
            //Act
            int points = _calculator.CalculatePoint(25);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "The 'age point calculator' should return 4 points from the given age of 35")]
        public void TestPointCalculation_InputIs35_ExpectedIs4()
        {
            //Act
            int points = _calculator.CalculatePoint(35);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }

        [Fact(DisplayName = "The 'age point calculator' should return 5 points from the given age of 50")]
        public void TestPointCalculation_InputIs50_ExpectedIs5()
        {
            //Act
            int points = _calculator.CalculatePoint(50);
            //Assert (expected, actual)
            Assert.StrictEqual(5, points);
        }

        [Fact(DisplayName = "The 'age point calculator' should return 6 points from the given age of 51")]
        public void TestPointCalculation_InputIs51_ExpectedIs6()
        {
            //Act
            int points = _calculator.CalculatePoint(51);
            //Assert (expected, actual)
            Assert.StrictEqual(6, points);
        }
    }
}
