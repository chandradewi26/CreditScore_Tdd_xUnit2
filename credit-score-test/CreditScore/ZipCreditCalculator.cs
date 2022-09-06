

namespace CreditScore
{
    public class ZipCreditCalculator : IZipCreditCalculator
    {
        public decimal CalculateCredit(Customer customer)
        {
            //method GetCalculatedPoints<Type of Calculator> where <Type of Calculator> is Interface IPointsCalculator, new () ??
            int GetCalculatedPoints<TCalculator>()
                where TCalculator : IPointsCalculator, new()
            {
                //return result of CalculatePoints<Type of Calculator>(customer);
                return this.CalculatePoints<TCalculator>(customer);
            }

            var bureauScorePoints = GetCalculatedPoints<BureauScoreCalculator>();
            var missedPaymentPoints = GetCalculatedPoints<MissedPaymentCalculator>();
            var completedPaymentPoints = GetCalculatedPoints<CompletedPaymentCalculator>();
            var ageCapPoints = GetCalculatedPoints<AgeCapPointCalculator>();

            var points = bureauScorePoints + missedPaymentPoints + completedPaymentPoints;

            //If user has BureauScorePoint 0 or lesser, they're automatically ineligible.
            if (bureauScorePoints <= 0)
            {
                return 0;
            }

            //If user has accumulative points of lesser than 0
            if (points <= 0)
            {
                return 0;
            }

            //If user has points more than age cap
            if (points > ageCapPoints)
            {
                return ageCapPoints * 100;
            }

            return points * 100;
        }

        //This method is called, first it created a new Calculator using the provided Calculator type, calculate point, and return ints
        private int CalculatePoints<TCalculator>(Customer customer) 
            where TCalculator : IPointsCalculator, new()
        {
            var calculator = new TCalculator();
            return calculator.CalculatePoints(customer);
        }
    }
}