using System;

namespace calculator.OneArgument
{
    public class Fraction : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Division by 0");
            }
            return 1 / firstArgument;
        }
    }
}
