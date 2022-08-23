namespace CreditScore.Interfaces
{
    public interface ICalculatorCreditModel
    {
        Decimal CalculateCredit(int age, int bureauScore, int missedPayment, int completedPayment);
    }
}