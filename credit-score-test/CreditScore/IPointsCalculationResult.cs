using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScore
{
    public interface IPointsCalculationResult
    {
        //This part needs to have Points, if not, the AgeCapPoint.Points @ ZipCreditCalculator class does not work.
        public int Points { get; }
    }
}
