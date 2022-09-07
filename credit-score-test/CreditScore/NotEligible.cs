using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScore
{
    public sealed class NotEligible : IPointsCalculationResult
    {
        public int Points => throw new NotImplementedException();
    }
}
