namespace CreditScore.Tests
{
    public class AgeCapPointCalculatorTests
    {
        private readonly AgeCapPointCalculator _calculator;

        public AgeCapPointCalculatorTests()
        {
            _calculator = new AgeCapPointCalculator();
        }

        [Theory(DisplayName = "Given customer's age, AgeCapPointCalculator should calculate the correct cap point ")]
        [InlineData(10,0)]
        [InlineData(18, 3)]
        [InlineData(25, 3)]
        [InlineData(26, 4)]
        [InlineData(35, 4)]
        [InlineData(36, 5)]
        [InlineData(50, 5)]
        [InlineData(51, 6)]
        [InlineData(60, 6)]
        public void TestPointCalculation_GivenAge_ReturnCorrectCapPoint(int inputValue, int expectedOutput)
        {
            var points = _calculator.CalculatePoint(inputValue);
            Assert.StrictEqual(expectedOutput, points);
        }

        [Fact(DisplayName = "When a customer is younger than 18 years old, AgeCapPointCalculator should return 0 cap point")]
        public void TestPointCalculation_AgeYoungerThan18_ShouldReturn0()
        {
            var points = _calculator.CalculatePoint(10);
            Assert.StrictEqual(0, points);
        }
    }
}
