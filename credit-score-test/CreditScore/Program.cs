using Microsoft.Extensions.DependencyInjection;
namespace CreditScore
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointCalculator ageCapPointCalculator = new AgeCapPointCalculator();
            IPointCalculator bureauScoreCalculator = new BureauScoreCalculator();
            IPointCalculator missedPaymentCalculator = new MissedPaymentCalculator();
            IPointCalculator completedPaymentCalculator = new CompletedPaymentCalculator();

            var _calculator = new ZipCreditCalculator(ageCapPointCalculator, bureauScoreCalculator, missedPaymentCalculator, completedPaymentCalculator);

            //Manual testing
            Console.WriteLine("Hello World");
            Customer customer1 = new Customer(29,750,1,4);
            Customer customer2 = new Customer(30, 500, 5, 1);
            Console.WriteLine(_calculator.CalculateCredit(customer1));
            Console.WriteLine(_calculator.CalculateCredit(customer2));
        }
    }
}