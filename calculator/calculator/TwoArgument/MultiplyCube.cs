using System;
namespace calculator.TwoArgument
{
    public class MultiplyCube : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 3) * Math.Pow(secondArgument, 3);
        }
    }
}
