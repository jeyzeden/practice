using System;
namespace calculator.OneArgument
{
    public class TwoExp : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }

    }
}