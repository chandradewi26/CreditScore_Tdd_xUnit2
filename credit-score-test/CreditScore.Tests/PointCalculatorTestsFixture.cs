using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScore.Tests
{
    //This is an abstract class in C#
    public abstract class PointCalculatorTestsFixture
    {
        private IPointsCalculator _calculator;

        //protected so that children class can use ?? why not private?
        protected abstract IPointsCalculator CreateCalculator();

        protected abstract Customer CreateTestCustomer(int inputValue);

        public void TestPointCalculation(int input, int expectedOutput)
        {
            _calculator = CreateCalculator();
            var customer = CreateTestCustomer(input);
            var points = _calculator.CalculatePoints(customer);
            Assert.StrictEqual(expectedOutput, points);
        }
    }
}
