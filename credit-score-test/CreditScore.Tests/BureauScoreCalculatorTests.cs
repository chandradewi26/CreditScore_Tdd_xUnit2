namespace CreditScore.Tests
{
    public class BureauScoreCalculatorTests
    {
        private readonly BureauScoreCalculator _calculator;

        public BureauScoreCalculatorTests()
        {
            _calculator = new BureauScoreCalculator();
        }

        [Fact(DisplayName = "Given 451 to 700 credit bureau, BureauScoreCalculator should return 1 point")]
        public void TestPointCalculation_BScore451to700_Return1Point()
        {
            TestPointCalculation(451, 1);
        }

        [Fact(DisplayName = "Given 701 to 850 credit bureau, BureauScoreCalculator should return 2 point")]
        public void TestPointCalculation_BScore701to850_Return2Point()
        {
            TestPointCalculation(701, 2);
        }

        [Fact(DisplayName = "Given 851 to 1000 credit bureau, BureauScoreCalculator should return 3 point")]
        public void TestPointCalculation_BScore851to1000_Return3Point()
        {
            TestPointCalculation(851, 3);
        }

        [Fact(DisplayName = "Given more than 1000 credit bureau, BureauScoreCalculator should return highest possible point (3)")]
        public void TestPointCalculation_BScoreMoreThan1000_Return3Point()
        {
            TestPointCalculation(1001, 3);
        }

        [Fact(DisplayName = "Given less than 450 credit bureau, BureauScoreCalculator should throw exception and the customer is not qualified")]
        public void TestPointCalculation_BScoreEqualOrLessThan450_ShouldThrowException()
        {
            Action action = () => _calculator.CalculatePoint(50);
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }

        private void TestPointCalculation(int inputValue, int expectedOutput)
        {
            var points = _calculator.CalculatePoint(inputValue);
            Assert.StrictEqual(expectedOutput, points);
        }
    }
}
