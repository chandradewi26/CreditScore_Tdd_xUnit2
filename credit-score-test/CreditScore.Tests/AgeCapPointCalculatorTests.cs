namespace CreditScore.Tests
{
    public class AgeCapPointCalculatorTests
    {
        private readonly AgeCapPointCalculator _calculator;

        public AgeCapPointCalculatorTests()
        {
            _calculator = new AgeCapPointCalculator();
        }

        [Fact(DisplayName = "When a customer is 18~25 years old, AgeCapPointCalculator should return maximum points of 3")]
        public void TestPointCalculation_Age18to25_Return3()
        {
            TestPointCalculation(18, 3);
        }

        [Fact(DisplayName = "When a customer is 26~35 years old, AgeCapPointCalculator should return maximum points of 4")]
        public void TestPointCalculation_Age26to35_Return4()
        {
            TestPointCalculation(26, 4);
        }

        [Fact(DisplayName = "When a customer is 36~50 years old, AgeCapPointCalculator should return maximum points of 5")]
        public void TestPointCalculation_Age36to50_Return5()
        {
            TestPointCalculation(36,5);
        }

        [Fact(DisplayName = "When a customer is at age or older than 51 years old, AgeCapPointCalculator should return maximum points of 6")]
        public void TestPointCalculation_Age51OrOlder_Return6()
        {
            TestPointCalculation(51,6);
        }

        [Fact(DisplayName = "When a customer is younger than 18 years old, AgeCapPointCalculator should throw exception")]
        public void TestPointCalculation_AgeYoungerThan18_ShouldThrowException()
        {
            Action action = () => _calculator.CalculatePoint(10);
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }

        public void TestPointCalculation(int inputValue, int expectedOutput)
        {
            var points = _calculator.CalculatePoint(inputValue);
            Assert.StrictEqual(expectedOutput, points);
        }
    }
}
