namespace CreditScore.Tests
{
    public class ZipCreditCalculatorTests
    {
        private readonly ZipCreditCalculator _calculator;

        public ZipCreditCalculatorTests()
        {
            _calculator = new ZipCreditCalculator();
        }
        
        [Fact(DisplayName = "Test1 : Customer, 29 years old, bureau score of 750, 1 missed payments and 4 completed payments, should return $400 credit at Zip")]
        public void TestCreditCalculator_Age29BScore750Missed1Completed4_Return400credits()
        {
            TestCreditCalculation(29, 750, 1, 4, 400);
        }
        
        [Fact(DisplayName = "Test2 : Customer, 20 years old, bureau score of 500, 1 missed payments and 3 completed payments, should return $300 credit at Zip")]
        public void TestCreditCalculator_Age20BScore500Missed1Completed3_Return300Credits()
        {
            TestCreditCalculation(20, 500, 1, 3, 300);
        }

        [Fact(DisplayName ="Test3 : Customer, 40 years old, bureau score of 900, 3 missed payments and 3 completed payments, should return $100 credit at Zip")]        
        public void TestCreditCalculator_Age40BScore900Missed3Completed3_Return100Credits()
        {
            TestCreditCalculation(40, 900, 3, 3, 100);
        }

        [Fact(DisplayName ="Test4 : Customer, 30 years old, bureau score of 900, 2 missed payments and 1 completed payments, should return $200 credit at Zip")]
        public void TestCreditCalculator_Age30BScore900Missed2Completed1_Return200Credits()
        {
            TestCreditCalculation(30, 900, 2, 1, 200);
        }

        [Fact(DisplayName ="Test5 : Customer, 30 years old, bureau score of 750, 2 missed payments and 3 completed payments, should return $300 credit at Zip")]
        public void TestCreditCalculator_Age30BScore750Missed2Completed3_Return300Credits()
        {
            TestCreditCalculation(30, 750, 2, 3, 300);
        }

        [Fact(DisplayName ="Test6 : Customer, 30 years old, bureau score of 800, 0 missed payments and 1 completed payments, should return $400 credits at Zip")]
        public void TestCreditCalculator_Age30BScore800Missed0Completed1_Return400Credits()
        {
            TestCreditCalculation(30, 800, 0, 1, 400);
        }

        [Fact(DisplayName ="Test7 : Customer, 55 years old, bureau score of 1100, 0 missed payments and 2 completed payments, should return $500 credits at Zip")]
        public void TestCreditCalculator_Age55BScore1100Missed0Completed2_Return500Credits()
        {
            TestCreditCalculation(55, 1100, 0, 2, 500);
        }

        [Fact(DisplayName ="Test8 : Customer, 60 years old, bureau score of 900, 1 missed payments and 3 completed payments, should return $600 credits at Zip")]
        public void TestCreditCalculator_Age60BScore900Missed1Completed3_Return600Credits()
        {
            TestCreditCalculation(60, 900, 1, 3, 600);
        }

        [Fact(DisplayName ="Test9 : Customer, 20 years old, bureau score of 900, 1 missed payments and 2 completed payments, should return $300 credits at Zip")]
        public void TestCreditCalculator_Age20BScore900Missed1Completed2_Return300Credits()
        {
            TestCreditCalculation(20, 900, 1, 2, 300);
        }

        [Fact(DisplayName ="Test10 : Customer, 30 years old, bureau score of 500, 5 missed payments and 1 completed payments, should throw exception")]
        public void TestCreditCalculator_Age30BScore500Missed5Completed1_ShouldThrowException()
        {
            TestCreditCalculation_ShouldThrowException(30, 500, 5, 1);
        }

        [Fact(DisplayName ="Test11 : Customer, 15 years old, bureau score of 200, 0 missed payments and 0 completed payments, should throw exception")]
        public void TestCreditCalculator_Age15BScore200Missed0Completed0_ShouldThrowException()
        {
            TestCreditCalculation_ShouldThrowException(15, 200, 0, 0);
        }

        [Fact(DisplayName ="Test12 : Customer, 30 years old, bureau score of 100, 0 missed payment and 3 completed payments, should throw exception")]
        public void TestCreditCalculator_Age30BScore100Missed0Completed3_ShouldThrowException()
        {
            TestCreditCalculation_ShouldThrowException(30, 100, 0, 3);
        }

        [Fact(DisplayName = "Test13 : Customer, 20 years old, bureau score of 500, 1 missed payments and 0 completed payments, should throw exception")]
        public void TestCreditCalculator_Age20BScore500Missed1Completed0_ShouldThrowException()
        {
            TestCreditCalculation_ShouldThrowException(20, 500, 1, 0);
        }

        private void TestCreditCalculation_ShouldThrowException(int age, int bureauScore, int missedPayment, int completedPayment)
        {
            Action action = () => _calculator.CalculateCredit(age, bureauScore, missedPayment, completedPayment);
            Assert.Throws<ArgumentOutOfRangeException>(action);

        }

        private void TestCreditCalculation(int age, int bureauScore, int missedPayment, int completedPayment, int expectedOutput)
        {
            var credits = _calculator.CalculateCredit(age, bureauScore, missedPayment, completedPayment);
            Assert.Equal(expectedOutput, credits);
        }
    }
}
