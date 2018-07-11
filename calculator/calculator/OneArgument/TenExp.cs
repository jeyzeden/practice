using System;
namespace calculator.OneArgument
{
    public class TenExp : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10,firstArgument);
        }

    }
}