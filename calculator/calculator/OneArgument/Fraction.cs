using System;

namespace calculator.OneArgument
{
    public class Fraction : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate 1 division on firstArgument
        /// invalid value 0
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Division by 0");
            }
            return 1 / firstArgument;
        }
    }
}
