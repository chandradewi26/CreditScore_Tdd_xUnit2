namespace CreditScore
{
    public class MissedPaymentCalculator : IPointsCalculator
    {
        public IPointsCalculationResult CalculatePoints(Customer customer)
        {
            var missedPayment = customer.MissedPaymentCount;

            if (missedPayment == 0)
                return new PointScore(0);
            if (missedPayment == 1)
                return new PointScore(-1);
            if (missedPayment == 2)
                return new PointScore(-3);
            if (missedPayment >= 3)
                return new PointScore(-6);
            return new PointScore(0);
        }
    }
}