using System;
namespace calculator.TwoArgument
{
    public class DivisionSquare : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("division by 0");
            }
            return Math.Pow(firstArgument, 2) / Math.Pow(secondArgument, 2);
        }
    }
}
