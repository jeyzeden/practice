using System;
namespace calculator.OneArgument
{
    
    public class Cube : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate firstArgument * firstArgument * firstArgument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 3);
        }

    }
}
