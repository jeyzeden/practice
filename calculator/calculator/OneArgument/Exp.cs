using System;
namespace calculator.OneArgument
{
    public class Exp : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(Math.E, firstArgument);
        }
    }
}
