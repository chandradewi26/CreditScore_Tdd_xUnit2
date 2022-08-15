namespace CreditScore
{
    public class AgeCapPointCalculator
    {
        public int CalculatePoint(int age)
        {
            if (age >= 18 && age <= 25)
                return 3;
            if (age >= 26 && age <= 35)
                return 4;
            if (age >= 36 && age <= 50)
                return 5;
            if (age >= 51)
                return 6;
            throw new ArgumentOutOfRangeException("All customers must be older than 18 years old");
        }
    }
}