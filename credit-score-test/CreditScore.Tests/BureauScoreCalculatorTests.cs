namespace CreditScore.Tests
{
    public class BureauScoreCalculatorTests
    {
        private readonly BureauScoreCalculator _calculator;

        public BureauScoreCalculatorTests()
        {
            _calculator = new BureauScoreCalculator();
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
            var points = _calculator.CalculatePoint(inputValue);
            Assert.StrictEqual(expectedOutput, points);
        }

        [Fact(DisplayName = "Given less than 450 credit bureau, BureauScoreCalculator should return 0 point")]
        public void TestPointCalculation_BScoreEqualOrLessThan450_ShouldReturn0()
        {
            var points = _calculator.CalculatePoint(0);
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "Given less than 0 credit bureau, BureauScoreCalculator should return 0 point")]
        public void TestPointCalculation_BScoreLessThan0_ShouldReturn0()
        {
            var points = _calculator.CalculatePoint(-50);
            Assert.StrictEqual(0, points);
        }
    }
}
