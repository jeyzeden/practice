using System;

namespace calculator.TwoArgument
{
    public class DivisionSquare : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Dividing squares
        /// Invalid value 0
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("division by 0");
            }
            return Math.Pow(firstArgument, 2) / Math.Pow(secondArgument, 2);
        }
    }
}
