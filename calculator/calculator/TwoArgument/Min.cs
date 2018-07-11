using System;
namespace calculator.TwoArgument
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}