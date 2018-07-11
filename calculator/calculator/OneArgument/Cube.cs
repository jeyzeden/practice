using System;
namespace calculator.OneArgument
{
    /// <summary>
    /// Calculate Cube
    /// </summary>
    /// <param name="firstArgument"></param>
    /// <returns></returns>
    public class Cube : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 3);
        }

    }
}
