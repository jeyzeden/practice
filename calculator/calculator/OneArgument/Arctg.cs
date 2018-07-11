using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Calculate Arctg
    /// </summary>
    /// <param name="firstArgument"></param>
    /// <returns></returns>
    public class Arctg : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
