using System;
namespace calculator.OneArgument
{
    public class Exp : IOneArgumentFactory
    {
        /// <summary>
        /// Сalculation of the exponent * exponent any (firstArgument) times
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(Math.E, firstArgument);
        }
    }
}
