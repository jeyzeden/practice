using System;
namespace calculator
{
    public class Module : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);

        }

    }
}
