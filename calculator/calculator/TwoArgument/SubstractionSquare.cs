using System;

namespace calculator.TwoArgument
{
    public class SubstractionSquare : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate difference of squares
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 2) - Math.Pow(secondArgument, 2);
        }
    }
}
