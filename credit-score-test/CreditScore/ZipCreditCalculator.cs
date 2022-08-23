namespace CreditScore
{
    public class ZipCreditCalculator : Interfaces.ICalculatorCreditModel
    {
        private readonly BureauScoreCalculator _bureauScoreCalculator = new BureauScoreCalculator();
        private readonly MissedPaymentCalculator _missedPaymentCalculator = new MissedPaymentCalculator();
        private readonly CompletedPaymentCalculator _completedPaymentCalculator = new CompletedPaymentCalculator();
        private readonly AgeCapPointCalculator _ageCalculator = new AgeCapPointCalculator();

        public Decimal CalculateCredit(int age, int bureauScore, int missedPayment, int completedPayment)
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