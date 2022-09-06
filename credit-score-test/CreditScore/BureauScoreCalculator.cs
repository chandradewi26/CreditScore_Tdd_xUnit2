namespace CreditScore
{
    public class BureauScoreCalculator : IPointsCalculator
    {
        public IPointsCalculationResult CalculatePoints(Customer customer)
        {
            var bureauScore = customer.BureauScore;

            if (bureauScore >= 451 && bureauScore <= 700)
                return new PointScore(1);
            if (bureauScore >= 701 && bureauScore <= 850)
                return new PointScore(2);
            if (bureauScore >= 851 && bureauScore <= 1000)
                return new PointScore(3);
            if (bureauScore >= 1000)
                return new PointScore(3);
            return new NotEligible();
        }
    }
}