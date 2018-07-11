using System;

namespace calculator.OneArgument
{
    public class Module : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}