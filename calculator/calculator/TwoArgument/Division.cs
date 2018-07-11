using System;
namespace calculator.TwoArgument
{
    public class Division: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Division
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
            return firstArgument / secondArgument;
        }
    }
}
