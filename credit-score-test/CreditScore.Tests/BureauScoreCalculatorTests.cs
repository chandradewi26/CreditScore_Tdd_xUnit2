namespace CreditScore.Tests
{
    public class BureauScoreCalculatorTests
    {
        private readonly BureauScoreCalculator _calculator;

        public BureauScoreCalculatorTests()
        {
            //Arrange
            _calculator = new BureauScoreCalculator();
        }

        [Fact(DisplayName = "Given 451 to 700 credit bureau, BureauScoreCalculator should return 1 point")]
        public void TestPointCalculation_BScore451to700_Return1Point()
        {
            //Act
            int points = _calculator.CalculatePoint(451);
            //Assert (expected, actual)
            Assert.StrictEqual(1, points);
        }

        [Fact(DisplayName = "Given 701 to 850 credit bureau, BureauScoreCalculator should return 2 point")]
        public void TestPointCalculation_BScore701to850_Return2Point()
        {
            //Act
            int points = _calculator.CalculatePoint(701);
            //Assert (expected, actual)
            Assert.StrictEqual(2, points);
        }

        [Fact(DisplayName = "Given 851 to 1000 credit bureau, BureauScoreCalculator should return 3 point")]
        public void TestPointCalculation_BScore851to1000_Return3Point()
        {
            //Act
            int points = _calculator.CalculatePoint(851);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "Given more than 1000 credit bureau, BureauScoreCalculator should return highest possible point (3)")]
        public void TestPointCalculation_BScoreMoreThan1000_Return3Point()
        {
            //Act
            int points = _calculator.CalculatePoint(1001);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "Given less than 450 credit bureau, BureauScoreCalculator should throw exception and the customer is not qualified")]
        public void TestPointCalculation_BScoreEqualOrLessThan450_ShouldThrowException()
        {
            //Act
            Action action = () => _calculator.CalculatePoint(50);
            //Assert
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        }

    }
}
