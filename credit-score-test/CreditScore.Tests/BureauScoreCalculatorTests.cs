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

        [Fact(DisplayName = "The 'BureauScoreCalculator' should return 0 points from the given bureau score of negative number of 10")]
        public void TestPointCalculation_BScoreIsNegativeNumber10_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(-10);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }
        [Fact(DisplayName = "The 'BureauScoreCalculator' should return 0 points from the given bureau score of lesser than or equal to 450")]
        public void TestPointCalculation_BScoreIsEqualOrLessThan450_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(50);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'BureauScoreCalculator' should return 1 points from the given bureau score range of 451 to 700")]
        public void TestPointCalculation_BScoreIsBetween451to700_ExpectedPointIs1()
        {
            //Act
            int points = _calculator.CalculatePoint(451);
            //Assert (expected, actual)
            Assert.StrictEqual(1, points);
        }

        [Fact(DisplayName = "The 'BureauScoreCalculator' should return 2 points from the given bureau score range of 701 to 850")]
        public void TestPointCalculation_BScoreIsBetween701to850_ExpectedPointIs2()
        {
            //Act
            int points = _calculator.CalculatePoint(850);
            //Assert (expected, actual)
            Assert.StrictEqual(2, points);
        }

        [Fact(DisplayName = "The 'BureauScoreCalculator' should return 3 points from the given bureau score range of 851 to 1000")]
        public void TestPointCalculation_BScoreIsBetween851to1000_ExpectedPointIs3()
        {
            //Act
            int points = _calculator.CalculatePoint(851);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }
        [Fact(DisplayName = "The 'BureauScoreCalculator' should return 0 points from the given bureau score more than 1000")]
        public void TestPointCalculation_BScoreIsMoreThan1000_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(1001);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }
    }
}
