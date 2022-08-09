﻿namespace CreditScore
{
    public class CompletedPaymentCalculator
    {
        public int CalculatePoint(int completedPayment)
        {
            if (completedPayment < 0)
                return 0;
            if (completedPayment == 0)
                return 0;
            if (completedPayment == 1)
                return 2;
            if (completedPayment == 2)
                return 3;
            if (completedPayment == 3)
                return 4;
            if (completedPayment > 3)
                return 4;
            throw new NotImplementedException();
        }
    }
}