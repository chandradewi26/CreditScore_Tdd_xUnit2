﻿using CreditScore.Interfaces;

namespace CreditScore
{
    public class MissedPaymentCalculator : ICalculatorPointModel
    {
        public int CalculatePoint(int missedPayment)
        {
            if (missedPayment == 0)
                return 0;
            if (missedPayment == 1)
                return -1;
            if (missedPayment == 2)
                return -3;
            if (missedPayment >= 3)
                return -6;
            return 0;
        }
    }
}