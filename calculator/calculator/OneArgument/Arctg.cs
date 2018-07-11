using System;

namespace calculator.OneArgument
{
    public class Arctg : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Arctg
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
