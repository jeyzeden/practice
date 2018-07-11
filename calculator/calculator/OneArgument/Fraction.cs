using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Calculate Fraction
    /// invalid value 0
    /// </summary>
    /// <param name="firstArgument"></param>
    /// <returns></returns>
    public class Fraction : IOneArgumentFactory
    {
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
