using System;

namespace calculator.OneArgument
{
    public class Module : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Module
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}