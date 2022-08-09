namespace CreditScore
{
    public class BureauScoreCalculator
    {
        public int CalculatePoint(int bureauScore)
        {
            if (bureauScore <= 450)
                return 0;
            if (bureauScore >= 451 && bureauScore <= 700)
                return 1;
            if (bureauScore >= 701 && bureauScore <= 850)
                return 2;
            if (bureauScore >= 851 && bureauScore <= 1000)
                return 3;
            if (bureauScore > 1000)
                return 0;
            throw new NotImplementedException();
        }
    }


}