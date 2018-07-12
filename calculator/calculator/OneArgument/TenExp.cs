using System;

namespace calculator.OneArgument
{
    public class TenExp : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate 10 ^ exponent
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10,firstArgument);
        }

    }
}