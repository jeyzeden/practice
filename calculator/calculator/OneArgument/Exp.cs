using System;
namespace calculator.OneArgument
{
    public class Exp : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Exp
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(Math.E, firstArgument);
        }
    }
}
