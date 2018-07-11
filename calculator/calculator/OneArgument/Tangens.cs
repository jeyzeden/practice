using System;
namespace calculator.OneArgument
{
    public class Tangens : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Tangens
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
