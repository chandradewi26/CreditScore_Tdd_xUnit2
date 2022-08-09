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

        [Fact(DisplayName = "The 'bureau score point calculator' should return 0 points from the given bureau score of 450")]
        public void TestPointCalculation_BScoreIs450_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(450);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }

        [Fact(DisplayName = "The 'bureau score point calculator' should return 1 points from the given bureau score of 700")]
        public void TestPointCalculation_BScoreIs700_ExpectedPointIs1()
        {
            //Act
            int points = _calculator.CalculatePoint(700);
            //Assert (expected, actual)
            Assert.StrictEqual(1, points);
        }

        [Fact(DisplayName = "The 'bureau score point calculator' should return 2 points from the given bureau score of 850")]
        public void TestPointCalculation_BScoreIs850_ExpectedPointIs2()
        {
            //Act
            int points = _calculator.CalculatePoint(850);
            //Assert (expected, actual)
            Assert.StrictEqual(2, points);
        }

        [Fact(DisplayName = "The 'bureau score point calculator' should return 3 points from the given bureau score of 1000")]
        public void TestPointCalculation_BScoreIs1000_ExpectedPointIs3()
        {
            //Act
            int points = _calculator.CalculatePoint(1000);
            //Assert (expected, actual)
            Assert.StrictEqual(3, points);
        }

        [Fact(DisplayName = "The 'bureau score point calculator' should return 0 points from the given bureau score of 1001 (invalid score)")]
        public void TestPointCalculation_BScoreIs1001_ExpectedPointIs0()
        {
            //Act
            int points = _calculator.CalculatePoint(1001);
            //Assert (expected, actual)
            Assert.StrictEqual(0, points);
        }
    }
}
