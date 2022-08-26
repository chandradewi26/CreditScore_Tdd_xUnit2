namespace CreditScore
{
    public class ZipCreditCalculator
    { 
        private readonly IAgeCapPointCalculator _ageCalculator;
        private readonly IBureauScoreCalculator _bureauScoreCalculator;
        private readonly IMissedPaymentCalculator _missedPaymentCalculator;
        private readonly ICompletedPaymentCalculator _completedPaymentCalculator;

        public ZipCreditCalculator(
            IAgeCapPointCalculator ageCalculator,
            IBureauScoreCalculator bureauCalculator,
            IMissedPaymentCalculator missedCalculator,
            ICompletedPaymentCalculator completedCalculator)
        {
            _ageCalculator = ageCalculator;
            _bureauScoreCalculator = bureauCalculator;
            _missedPaymentCalculator = missedCalculator;
            _completedPaymentCalculator = completedCalculator;
        }

        public decimal CalculateCredit(int age, int bureauScore, int missedPayment, int completedPayment)
        {
            var capPoints = _ageCalculator.CalculatePoint(age);

            var points = 0;
            points += _bureauScoreCalculator.CalculatePoint(bureauScore);
            points += _missedPaymentCalculator.CalculatePoint(missedPayment);
            points += _completedPaymentCalculator.CalculatePoint(completedPayment);
            
            if (points > capPoints)
            {
                return Convert.ToDecimal(capPoints * 100);
            }

            if (points <= 0)
            {
                return 0;
            }

            if (_bureauScoreCalculator.CalculatePoint(bureauScore) <= 0)
            {
                return 0;
            }

            return Convert.ToDecimal(points * 100);
        }

    }
}