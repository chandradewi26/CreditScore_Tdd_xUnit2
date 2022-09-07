using Microsoft.Extensions.DependencyInjection;
namespace CreditScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var _calculator = new ZipCreditCalculator();

            //Manual testing
            Console.WriteLine("Hello World");
            Customer customer1 = new Customer(750,1,4,29);
            //Expected to print 400
            Customer customer2 = new Customer(500,1,3,20);
            //Expected to print 500
            Console.WriteLine("Customer1's credit" + _calculator.CalculateCredit(customer1));
            Console.WriteLine("Customer2's credit" + _calculator.CalculateCredit(customer2));
        }
    }
}