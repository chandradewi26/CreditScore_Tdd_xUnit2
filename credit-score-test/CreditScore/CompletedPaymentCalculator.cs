﻿namespace CreditScore
{
    public interface ICompletedPaymentCalculator
    {
        int CalculatePoint(int completedPayment);
    }
    public class CompletedPaymentCalculator : ICompletedPaymentCalculator
    {
        public int CalculatePoint(int completedPayment)
        {
            if (completedPayment == 0)
                return 0;
            if (completedPayment == 1)
                return 2;
            if (completedPayment == 2)
                return 3;
            if (completedPayment >= 3)
                return 4;
            return 0;
        }
    }
}