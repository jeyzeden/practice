using System;
namespace calculator.OneArgument
{
    public class TwoExp : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate 2 ^ exponent
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}