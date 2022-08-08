using CreditScore;


namespace CreditScore.Tests
{
    public class CreditScore_IsTest
    {
        private readonly AgePointCalculator _calculator;

        public CreditScore_IsTest()
        {
            _calculator = new AgePointCalculator();
        }


        [Theory]
        [InlineData(-100,0)]
        [InlineData(15, 0)]
        [InlineData(20, 3)]
        [InlineData(26, 4)]
        [InlineData(39, 5)]
        [InlineData(55, 6)]
        public void CalculatePoint_GivenAge_ShouldReturnCorrectPoins(int age, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(age);

            //Assert
            Assert.StrictEqual(expectedPoints, points);
            //$"\nAge : {age}\nPoints should be equal"
        }


    }
}
