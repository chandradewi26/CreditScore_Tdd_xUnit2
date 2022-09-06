using Microsoft.Extensions.DependencyInjection;

namespace CreditScore.Tests
{
    public class ZipCreditCalculatorTests
    {
        private readonly ZipCreditCalculator _calculator;

        public ZipCreditCalculatorTests()
        {
            _calculator = new ZipCreditCalculator();
        }

        private void TestCreditCalculation(int bureauScore, int missedPayment, int completedPayment, int age, int expectedOutput)
        {
            var customer = CreateCustomer(bureauScore, missedPayment, completedPayment, age);
            var credits = _calculator.CalculateCredit(customer);
            Assert.Equal(expectedOutput, credits);
        }

        private Customer CreateCustomer(int bureauScore, int missedPayment, int completedPayment, int age)
        {
            return new Customer (bureauScore, missedPayment, completedPayment, age);
        }

        [Fact(DisplayName = "Test1 : Customer, bureau score of 750, 1 missed payments, 4 completed payments and 29 years old, should return $400 credit at Zip")]
        public void TestCreditCalculator_BScore750Missed1Completed4Age29_Return400credits()
        {
            TestCreditCalculation(750, 1, 4, 29, 400);
        }

        [Fact(DisplayName = "Test2 : Customer, bureau score of 500, 1 missed payments, 3 completed payments and 20 years old, should return $300 credit at Zip")]
        public void TestCreditCalculator_BScore500Missed1Completed3Age20_Return300Credits()
        {
            TestCreditCalculation(500, 1, 3, 20, 300);
        }

        [Fact(DisplayName = "Test3 : Customer, bureau score of 900, 3 missed payments, 3 completed payments and 40 years old, should return $100 credit at Zip")]        
        public void TestCreditCalculator_BScore900Missed3Completed3Age40_Return100Credits()
        {
            TestCreditCalculation(900, 3, 3, 40, 100);
        }

        [Fact(DisplayName = "Test4 : Customer, bureau score of 900, 2 missed payments, 1 completed payments and 30 years old, should return $200 credit at Zip")]
        public void TestCreditCalculator_BScore900Missed2Completed1Age30_Return200Credits()
        {
            TestCreditCalculation(900, 2, 1, 30, 200);
        }

        [Fact(DisplayName = "Test5 : Customer, bureau score of 750, 2 missed payments, 3 completed payments and 30 years old, should return $300 credit at Zip")]
        public void TestCreditCalculator_BScore750Missed2Completed3Age30_Return300Credits()
        {
            TestCreditCalculation(750, 2, 3, 30, 300);
        }

        [Fact(DisplayName = "Test6 : Customer, score of 800, 0 missed payments, 1 completed payments, and 30 years old, should return $400 credits at Zip")]
        public void TestCreditCalculator_BScore800Missed0Completed1Age30_Return400Credits()
        {
            TestCreditCalculation(800, 0, 1, 30, 400);
        }

        [Fact(DisplayName = "Test7 : Customer, score of 900, 0 missed payments, 1 completed payments, and 55 years old, should return $500 credits at Zip")]
        public void TestCreditCalculator_BScore900Missed0Completed1Age55_Return500Credits()
        {
            TestCreditCalculation(900, 0, 1, 55, 500);
        }

        [Fact(DisplayName = "Test8 : Customer, score of 1200, 1 missed payments, 3 completed payments, and 60 years old, should return $600 credits at Zip")]
        public void TestCreditCalculator_BScore1200Missed1Completed3Age60_Return600Credits()
        {
            TestCreditCalculation(1200, 1, 3, 60, 600);
        }

        [Fact(DisplayName = "Test9 : Customer, score of 900, 1 missed payments, 2 completed payments, and 20 years old, should return $300 credits at Zip")]
        public void TestCreditCalculator_BScore900Missed1Completed2Age20_Return300Credits()
        {
            TestCreditCalculation(900, 1, 2, 20, 300);
        }

        [Fact(DisplayName = "Test10 : Customer, score of 500, 5 missed payments, 1 completed payments, and 30 years old, should return $0 credits, customer is not qualified")]
        public void TestCreditCalculator_BScore500Missed5Completed1Age30_Return0Credit()
        {
            TestCreditCalculation(500, 5, 1, 30, 0);
        }

        [Fact(DisplayName = "Test11 : Customer, score of 950, 0 missed payments, 2 completed payments, and 15 years old, should return $0 credits, customer is not qualified")]
        public void TestCreditCalculator_BScore950Missed0Completed2Age15_Return0Credit()
        {
            TestCreditCalculation(950, 0, 2, 15, 0);
        }

        [Fact(DisplayName = "Test12 : Customer, score of 100, 0 missed payment and 3 completed payments, and 30 years old, should return $0 credits, customer is not qualified")]
        public void TestCreditCalculator_BScore100Missed0Completed3Age30_Return0Credit()
        {
            TestCreditCalculation(100, 0, 3, 30, 0);
        }

        [Fact(DisplayName = "Test13 : Customer, score of 500, 1 missed payments, 0 completed payments, and 20 years old, should return $0 credits, customer is not qualified")]
        public void TestCreditCalculator_BScore500Missed1Completed0Age20_Return0Credit()
        {
            TestCreditCalculation(500, 1, 0, 20, 0);
        }
    }
}
