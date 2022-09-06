using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScore
{
    public class Customer
    {
        //Preferably not having set; to avoid further change of content.
        public int BureauScore { get; set; }
        public int MissedPaymentCount { get; set; }
        public int CompletedPaymentCount { get; set; }
        public int Age { get; set; }

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
