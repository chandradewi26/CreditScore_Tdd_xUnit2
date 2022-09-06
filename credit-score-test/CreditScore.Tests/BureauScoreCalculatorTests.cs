namespace CreditScore.Tests
{
    public class BureauScoreCalculatorTests : PointCalculatorTestsFixture
    {
        protected override IPointCalculator CreateCalculator()
        {
            return new BureauScoreCalculator();
        }

        protected override Customer CreateTestCustomer(int inputValue)
        {
            return new Customer(inputValue, 0, 0, 0);
        }

        [Theory(DisplayName = "Given customer's credit bureau, BureauScoreCalculator should calculate the correct point")]
        [InlineData(0, 0)]
        [InlineData(450, 0)]
        [InlineData(451, 1)]
        [InlineData(700, 1)]
        [InlineData(701, 2)]
        [InlineData(850, 2)]
        [InlineData(851, 3)]
        [InlineData(1000, 3)]
        [InlineData(1200, 3)]
        public void TestPointCalculation_GivenCreditBureau_ReturnCorrectPoint(int inputValue, int expectedOutput)
        {

            TestPointCalculation(inputValue, expectedOutput);
        }
        [Fact(DisplayName = "Given less than 450 credit bureau, BureauScoreCalculator should return 0 point")]
        public void TestPointCalculation_BScoreLessThan0_ShouldReturn0()
        {
            TestPointCalculation(-50, 0);
        }
    }
}
