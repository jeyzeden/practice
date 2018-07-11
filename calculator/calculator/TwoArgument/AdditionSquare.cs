using System;
namespace calculator.TwoArgument
{
    public class AdditionSquare : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Adding squares
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 2) + Math.Pow(secondArgument, 2);
        }
    }
}
