using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScore
{
    public class Customer
    {
        //Preferably not having set; to avoid changes of raw data.
        public int BureauScore { get; }
        public int MissedPaymentCount { get; }
        public int CompletedPaymentCount { get; }
        public int Age { get; }

        public Customer(int bureauScore, int missedPaymentCount,
            int completedPaymentCount, int ageInYears)
        {
            BureauScore = bureauScore;
            MissedPaymentCount = missedPaymentCount;
            CompletedPaymentCount = completedPaymentCount;
            Age = ageInYears;
        }
    }
}
