using System;
namespace calculator
{
    public class Square : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }

    }
}
