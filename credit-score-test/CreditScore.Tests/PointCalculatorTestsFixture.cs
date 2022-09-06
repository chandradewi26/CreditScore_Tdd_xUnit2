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
        private  IPointCalculator _calculator;

        //protected so that children class can use ?? why not private?
        protected abstract IPointCalculator CreateCalculator();

        protected abstract Customer CreateTestCustomer(int inputValue);

        public void TestPointCalculation(int input, int expectedOutput)
        {
            _calculator = CreateCalculator();
            var customer = CreateTestCustomer(input);
            var points = _calculator.CalculatePoint(customer);
            Assert.StrictEqual(expectedOutput, points);
        }
    }
}
