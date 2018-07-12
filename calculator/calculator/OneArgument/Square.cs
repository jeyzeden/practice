using System;

namespace calculator.OneArgument
{
    public class Square : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate firstArgument * firstArgument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }

    }
}
