namespace CreditScore
{
    public class BureauScoreCalculator : IPointCalculator
    {
        public int CalculatePoint(Customer customer)
        {
            var bureauScore = customer.BureauScore;
            if (bureauScore >= 451 && bureauScore <= 700)
                return 1;
            if (bureauScore >= 701 && bureauScore <= 850)
                return 2;
            if (bureauScore >= 851 && bureauScore <= 1000)
                return 3;
            if (bureauScore >= 1000)
                return 3;
            return 0;
        }
    }
}