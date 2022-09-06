namespace CreditScore
{
    public class AgeCapPointCalculator : IPointsCalculator
    {
        public IPointsCalculationResult CalculatePoints(Customer customer)
        {
            var age = customer.Age;

            if (age >= 18 && age <= 25)
                return new PointScore(3);
            if (age >= 26 && age <= 35)
                return new PointScore(4);
            if (age >= 36 && age <= 50)
                return new PointScore(5);
            if (age >= 51)
                return new PointScore(6);
            return new NotEligible();
        }
    }
}