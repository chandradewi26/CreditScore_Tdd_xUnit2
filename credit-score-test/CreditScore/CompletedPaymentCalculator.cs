namespace CreditScore
{
    public class CompletedPaymentCalculator : IPointsCalculator
    {
        public IPointsCalculationResult CalculatePoints(Customer customer)
        {
            var completedPayment = customer.CompletedPaymentCount;

            if (completedPayment == 0)
                return new PointScore(0);
            if (completedPayment == 1)
                return new PointScore(2);
            if (completedPayment == 2)
                return new PointScore(3);
            if (completedPayment >= 3)
                return new PointScore(4);
            return new PointScore(0);
        }
    }
}