namespace CreditScore
{
    //What is sealed?
    //public sealed class PointScore : IPointCalculationResult
    public class PointScore : IPointsCalculationResult
    {
        public int Points { get; }

        public PointScore (int points)
        {
            Points = points;
        }   
    }
}
