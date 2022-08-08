using System;

namespace CreditScore
{
    public class CompletedPaymentCalculator
    {
        public int CalculatePoint(int completedPayment)
        {
            int point = 0;
            if (completedPayment <= 0)
            {
                point = 0;
            }
            else if (completedPayment == 1)
            {
                point = 2;
            }
            else if (completedPayment == 2)
            {
                point = 3;
            }
            else if (completedPayment >= 3)
            {
                point = 4;
            }
            return point;
        }
    }
}