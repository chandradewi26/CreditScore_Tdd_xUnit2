using Microsoft.Extensions.DependencyInjection;
namespace CreditScore
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. We need a service collection
            var collection = new ServiceCollection();
            collection.AddScoped<IAgeCapPointCalculator, AgeCapPointCalculator>();
            collection.AddScoped<IBureauScoreCalculator, BureauScoreCalculator>();
            collection.AddScoped<IMissedPaymentCalculator, MissedPaymentCalculator>();
            collection.AddScoped<ICompletedPaymentCalculator, CompletedPaymentCalculator>();

            //2.Instance of service provider
            var provider = collection.BuildServiceProvider();

            //3.IBusiness biz = provider.GetService<IBusiness>();
            IAgeCapPointCalculator ageCapPointCalculator = provider.GetService<IAgeCapPointCalculator>();  
            IBureauScoreCalculator bureauScoreCalculator = provider.GetService<IBureauScoreCalculator>();
            IMissedPaymentCalculator missedPaymentCalculator = provider.GetService<IMissedPaymentCalculator>();   
            ICompletedPaymentCalculator completedPaymentCalculator = provider.GetService<ICompletedPaymentCalculator>();

            //4. var userInterface = new UserInterface(biz);
            var _calculator = new ZipCreditCalculator(ageCapPointCalculator, bureauScoreCalculator, missedPaymentCalculator, completedPaymentCalculator);

            //Manual testing
            Console.WriteLine("Hello World");
            Console.WriteLine(_calculator.CalculateCredit(29, 750, 1, 4));
            Console.WriteLine(_calculator.CalculateCredit(30, 500, 5, 1));
        }
    }
}