using System;
namespace calculator.TwoArgument
{
    public class AdditionCube : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Adding cubes
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 3) + Math.Pow(secondArgument, 3);
        }
    }
}
