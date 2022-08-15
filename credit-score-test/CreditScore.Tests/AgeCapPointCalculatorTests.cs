namespace CreditScore.Tests
{
    public class AgeCapPointCalculatorTests
    {
        //Arrange
        private readonly AgeCapPointCalculator _calculator;

        public AgeCapPointCalculatorTests()
        {
            //Arrange
            _calculator = new AgeCapPointCalculator();
        }

        [Fact(DisplayName = "When a customer is 18~25 years old, AgeCapPointCalculator should return maximum points of 3")]
        public void TestPointCalculation_Age18to25_Return3()
        {
            //Act
            int points = _calculator.CalculatePoint(18);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "When a customer is 26~35 years old, AgeCapPointCalculator should return maximum points of 4")]
        public void TestPointCalculation_Age26to35_Return4()
        {
            //Act
            int points = _calculator.CalculatePoint(26);
            //Assert (expected, actual)
            Assert.StrictEqual(4, points);
        }


        [Fact(DisplayName = "When a customer is 36~50 years old, AgeCapPointCalculator should return maximum points of 5")]
        public void TestPointCalculation_Age36to50_Return5()
        {
            //Act
            int points = _calculator.CalculatePoint(36);
            //Assert (expected, actual)
            Assert.StrictEqual(5, points);
        }

        [Fact(DisplayName = "When a customer is at age or older than 51 years old, AgeCapPointCalculator should return maximum points of 6")]
        public void TestPointCalculation_Age51OrOlder_Return6()
        {
            //Act
            int points = _calculator.CalculatePoint(51);
            //Assert (expected, actual)
            Assert.StrictEqual(6, points);
        }

        [Fact(DisplayName = "When a customer is younger than 18 years old, AgeCapPointCalculator should throw exception")]
        public void TestPointCalculation_AgeYoungerThan18_ShouldThrowException()
        {
            //Act
            Action action = () => _calculator.CalculatePoint(10);
            //Assert
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        }

    }
}
