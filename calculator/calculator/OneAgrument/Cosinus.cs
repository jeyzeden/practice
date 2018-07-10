using System;
namespace calculator
{
    public class Cosinus : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}