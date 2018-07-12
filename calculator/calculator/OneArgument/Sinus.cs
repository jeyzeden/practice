using System;

namespace calculator.OneArgument
{
    public class Sinus : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Sinus
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);

        }

    }
}
