using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScore.Tests
{
    //This is an abstract class in C# for every calculator
    public abstract class PointCalculatorTestsFixture
    {
        private IPointsCalculator? _calculator;

        protected abstract IPointsCalculator CreateCalculator();

        protected abstract Customer CreateTestCustomer(int inputValue);

        public void TestPointCalculation(int input, int expectedOutput)
        {
            _calculator = CreateCalculator();
            var customer = CreateTestCustomer(input);
            var result = _calculator.CalculatePoints(customer);
            //Check if result is type of PointScore
            Assert.IsType<PointScore>(result);
            // idk what is this line about?
            var pointScore = result as PointScore;
            //retrieve the point
            Assert.Equal(expectedOutput, pointScore.Points);
        }

        public void TestPointCalculation_ShouldReturnNotEligible(int input)
        {
            _calculator = CreateCalculator();
            var customer = CreateTestCustomer(input);
            var points = _calculator.CalculatePoints(customer);
            Assert.IsType<NotEligible>(points);
        }
    }
}
