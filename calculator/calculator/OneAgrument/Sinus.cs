using System;
namespace calculator
{
    public class Sinus : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);

        }

    }
}
