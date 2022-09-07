

namespace CreditScore
{
    public class ZipCreditCalculator : IZipCreditCalculator
    {
        public decimal CalculateCredit(Customer customer)
        {
            //method GetCalculatedPoints<Type of Calculator> where <Type of Calculator> is Interface IPointsCalculator, new () ??
            IPointsCalculationResult GetCalculatedPoints<TCalculator>()
                where TCalculator : IPointsCalculator, new()
            {
                //return result of CalculatePoints<Type of Calculator>(customer);
                return this.CalculatePoints<TCalculator>(customer);
            }

            var bureauScorePoints = GetCalculatedPoints<BureauScoreCalculator>();
            var missedPaymentPoints = GetCalculatedPoints<MissedPaymentCalculator>();
            var completedPaymentPoints = GetCalculatedPoints<CompletedPaymentCalculator>();
            var ageCapPoints = GetCalculatedPoints<AgeCapPointCalculator>();

            if (bureauScorePoints is NotEligible)
            {
                return 0;
            }

            if (ageCapPoints is NotEligible)
            {
                return 0;
            }

            //Assign them into new array
            var points = new[] { bureauScorePoints, missedPaymentPoints, completedPaymentPoints};

            //What is cast?
            var subTotal = points.Where(p => p is PointScore).Cast<PointScore>().Sum(p => p.Points);


            var totalPoints = subTotal >= ageCapPoints.Points ? ageCapPoints.Points : subTotal;

            switch (totalPoints)
            {
                case <= 0:
                    return 0;
                case 1:
                    return 100;
                case 2:
                    return 200;
                case 3:
                    return 300;
                case 4:
                    return 400;
                case 5:
                    return 500;
                case 6:
                    return 600;
                default:
                    return 0;
            };
        }

        //This method is called, first it created a new Calculator using the provided Calculator type, calculate point, and return ints
        private IPointsCalculationResult CalculatePoints<TCalculator>(Customer customer) 
            where TCalculator : IPointsCalculator, new()
        {
            var calculator = new TCalculator();
            return calculator.CalculatePoints(customer);
        }
    }
}