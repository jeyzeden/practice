using System;

namespace calculator.TwoArgument
{
    public class Min : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Min value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}