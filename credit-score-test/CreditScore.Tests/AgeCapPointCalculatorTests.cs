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

        [Fact(DisplayName = "The AgeCapPointCalculator should not allow customer younger than 18 years old")]
        public void TestPointCalculation_AgeYoungerThan18_ShouldReturnNotEligible()
        {
            TestPointCalculation_ShouldReturnNotEligible(10);
        }
    }
}