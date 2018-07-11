using System;
namespace calculator.TwoArgument
{
    public class MultiplySquare : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 2) * Math.Pow(secondArgument, 2);
        }
    }
}
