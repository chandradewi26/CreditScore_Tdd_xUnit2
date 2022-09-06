namespace CreditScore
{
    public class ZipCreditCalculator
    { 
        private readonly IPointCalculator _ageCalculator;
        private readonly IPointCalculator _bureauScoreCalculator;
        private readonly IPointCalculator _missedPaymentCalculator;
        private readonly IPointCalculator _completedPaymentCalculator;

        public ZipCreditCalculator(
            IPointCalculator ageCalculator,
            IPointCalculator bureauCalculator,
            IPointCalculator missedCalculator,
            IPointCalculator completedCalculator)
        {
            _ageCalculator = ageCalculator;
            _bureauScoreCalculator = bureauCalculator;
            _missedPaymentCalculator = missedCalculator;
            _completedPaymentCalculator = completedCalculator;
        }

        public decimal CalculateCredit(Customer customer)
        {

            var capPoints = _ageCalculator.CalculatePoint(customer);

            var points = 0;
            points += _bureauScoreCalculator.CalculatePoint(customer);
            points += _missedPaymentCalculator.CalculatePoint(customer);
            points += _completedPaymentCalculator.CalculatePoint(customer);
            
            if (points > capPoints)
            {
                return Convert.ToDecimal(capPoints * 100);
            }

            if (points <= 0)
            {
                return 0;
            }

            if (_bureauScoreCalculator.CalculatePoint(customer) <= 0)
            {
                return 0;
            }

            return Convert.ToDecimal(points * 100);
        }

    }
}