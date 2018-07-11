using System;

namespace calculator.OneArgument
{
    public class Arctg : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
