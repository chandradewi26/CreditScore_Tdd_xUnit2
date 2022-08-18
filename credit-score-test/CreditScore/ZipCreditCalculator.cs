namespace CreditScore
{
    public class ZipCreditCalculator
    {

        private readonly BureauScoreCalculator _bureauScoreCalculator = new BureauScoreCalculator();
        private readonly MissedPaymentCalculator _missedPaymentCalculator = new MissedPaymentCalculator();
        private readonly CompletedPaymentCalculator _completedPaymentCalculator = new CompletedPaymentCalculator();
        private readonly AgeCapPointCalculator _ageCalculator = new AgeCapPointCalculator();


        public Decimal CalculateCredit(int age, int bureauScore, int missedPayment, int completedPayment)
        {
            var capPoints = _ageCalculator.CalculatePoint(age);
            var points = 0;
            points = points + _bureauScoreCalculator.CalculatePoint(bureauScore);
            points = points + _missedPaymentCalculator.CalculatePoint(missedPayment);
            points = points + _completedPaymentCalculator.CalculatePoint(completedPayment);

            if (points > capPoints)
            {
                return Convert.ToDecimal(capPoints * 100);
            }
            if ( points <= 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(points), "Customer with 0 points or below is not qualified");
            }
            return Convert.ToDecimal(points * 100);
        }

    }
}