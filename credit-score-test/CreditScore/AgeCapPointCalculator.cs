namespace CreditScore
{
    public interface IAgeCapPointCalculator
    {
        int CalculatePoint(int age);
    }
    public class AgeCapPointCalculator : IAgeCapPointCalculator
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
            return 0;
        }
    }
}