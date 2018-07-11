using System;
namespace calculator.TwoArgument
{
    public class Max : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}
