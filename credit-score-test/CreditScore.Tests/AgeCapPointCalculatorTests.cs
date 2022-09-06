namespace CreditScore.Tests
{
    public class AgeCapPointCalculatorTests : PointCalculatorTestsFixture
    {
        //why protected? why not private?
        protected override IPointsCalculator CreateCalculator()
        {
            return new AgeCapPointCalculator();
        }

        protected override Customer CreateTestCustomer(int inputValue)
        {
            return new Customer(0, 0, 0, inputValue);
        }

        [Theory(DisplayName = "Given customer's age, AgeCapPointCalculator should calculate the correct cap point ")]
        [InlineData(10, 0)]
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
            TestPointCalculation(inputValue, expectedOutput);
        }

        [Fact(DisplayName = "When a customer is younger than 18 years old, AgeCapPointCalculator should return 0 cap point")]
        public void TestPointCalculation_AgeYoungerThan18_ShouldReturn0()
        {
            TestPointCalculation(10, 0);
        }
    }
}