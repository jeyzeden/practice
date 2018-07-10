using System;

namespace calculator.OneArgument
{
    public class Cosinus : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}