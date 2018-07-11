using System;

namespace calculator.OneArgument
{
    public class Cosinus : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Cosinus
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}