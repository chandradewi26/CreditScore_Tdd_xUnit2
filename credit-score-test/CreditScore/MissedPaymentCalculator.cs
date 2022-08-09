namespace CreditScore
{
    public class MissedPaymentCalculator
    {
        public int CalculatePoint(int missedPayment)
        {
            int point = 0;
            if (missedPayment <= 0)
            {
                point = 0;
            }
            else if (missedPayment == 1)
            {
                point = -1;
            }
            else if (missedPayment == 2)
            {
                point = -3;
            }
            else if (missedPayment >= 3)
            {
                point = -6;
            }
            return point;
        }
    }
}