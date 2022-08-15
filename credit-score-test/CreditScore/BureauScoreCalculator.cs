namespace CreditScore
{
    public class BureauScoreCalculator
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
            throw new ArgumentOutOfRangeException("All customers must have at least 451 credit bureau to be qualified");
        }
    }


}