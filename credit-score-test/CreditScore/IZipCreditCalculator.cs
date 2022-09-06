using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScore
{
    public interface IZipCreditCalculator
    {
        decimal CalculateCredit(Customer customer);
    }
}
