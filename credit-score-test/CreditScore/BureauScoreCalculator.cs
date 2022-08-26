namespace CreditScore
{
    public interface IBureauScoreCalculator
    {
        int CalculatePoint(int bureauScore);
    }
    public class BureauScoreCalculator : IBureauScoreCalculator
    {
        public int CalculatePoint(int bureauScore)
        {
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