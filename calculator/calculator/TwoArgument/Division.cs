using System;
namespace calculator.TwoArgument
{
    public class Division: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("division by 0");
            }
            return firstArgument / secondArgument;
        }
    }
}
