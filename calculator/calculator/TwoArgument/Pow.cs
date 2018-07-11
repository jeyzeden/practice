using System;
namespace calculator.TwoArgument
{
    public class Pow : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Multiply
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
