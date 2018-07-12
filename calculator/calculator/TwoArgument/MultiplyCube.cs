using System;

namespace calculator.TwoArgument
{
    public class MultiplyCube : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Multiplying cubes
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 3) * Math.Pow(secondArgument, 3);
        }
    }
}
