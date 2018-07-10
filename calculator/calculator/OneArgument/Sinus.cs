using System;
namespace calculator.OneArgument
{
    public class Sinus : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);

        }

    }
}
