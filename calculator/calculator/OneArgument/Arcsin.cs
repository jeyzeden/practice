using System;

namespace calculator.OneArgument
{
    public class Arcsin : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Arcsin
        /// invalid values before -1 and after 1
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
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