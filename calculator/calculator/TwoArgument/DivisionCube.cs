using System;
namespace calculator.TwoArgument
{
    public class DivisionCube : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("division by 0");
            }
            return Math.Pow(firstArgument, 3) / Math.Pow(secondArgument, 3);
        }
    }
}
