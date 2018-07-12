using System;

namespace calculator.TwoArgument
{
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Max value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}
