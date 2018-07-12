using System;

namespace calculator.TwoArgument
{
    public class DivisionCube : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate dividing cubes
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
            return Math.Pow(firstArgument, 3) / Math.Pow(secondArgument, 3);
        }
    }
}
