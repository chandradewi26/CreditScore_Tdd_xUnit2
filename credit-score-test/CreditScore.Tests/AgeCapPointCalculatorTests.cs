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
            var points = _calculator.CalculatePoint(18);
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "When a customer is 26~35 years old, AgeCapPointCalculator should return maximum points of 4")]
        public void TestPointCalculation_Age26to35_Return4()
        {
            var points = _calculator.CalculatePoint(26);
            Assert.StrictEqual(4, points);
        }

        [Fact(DisplayName = "When a customer is 36~50 years old, AgeCapPointCalculator should return maximum points of 5")]
        public void TestPointCalculation_Age36to50_Return5()
        {
            var points = _calculator.CalculatePoint(36);
            Assert.StrictEqual(5, points);
        }

        [Fact(DisplayName = "When a customer is at age or older than 51 years old, AgeCapPointCalculator should return maximum points of 6")]
        public void TestPointCalculation_Age51OrOlder_Return6()
        {
            var points = _calculator.CalculatePoint(51);
            Assert.StrictEqual(6, points);
        }

        [Fact(DisplayName = "When a customer is younger than 18 years old, AgeCapPointCalculator should throw exception")]
        public void TestPointCalculation_AgeYoungerThan18_ShouldThrowException()
        {
            Action action = () => _calculator.CalculatePoint(10);
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }
    }
}
