namespace CreditScore
{
    class Program
    {
        //IBusiness biz = new BusinessV2(dal);
        static private readonly IAgeCapPointCalculator _ageCapCalculator = new AgeCapPointCalculator();
        static private readonly IBureauScoreCalculator _bureauScoreCalculator = new BureauScoreCalculator();
        static private readonly IMissedPaymentCalculator _missedPaymentCalculator = new MissedPaymentCalculator();
        static private readonly ICompletedPaymentCalculator _completedPaymentCalculator = new CompletedPaymentCalculator();

        static void Main(string[] args)
        {
            //var userInterface = new UserInterface(biz);
            ZipCreditCalculator _calculator = new ZipCreditCalculator(_ageCapCalculator, _bureauScoreCalculator, _missedPaymentCalculator, _completedPaymentCalculator);

            //Manual testing
            Console.WriteLine("Hello World");
            Console.WriteLine(_calculator.CalculateCredit(29, 750, 1, 4));
            Console.WriteLine(_calculator.CalculateCredit(30, 500, 5, 1));
        }
    }
}