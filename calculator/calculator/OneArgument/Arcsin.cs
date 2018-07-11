using System;

namespace calculator.OneArgument
{
    public class Arcsin : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Does't exsist");
            }
            return Math.Asin(firstArgument);
        }
    }
}