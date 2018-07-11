using System;

namespace calculator.OneArgument
{
    public class Ln : IOneArgumentFactory
    {
        /// <summary>
        /// Calculate Ln
        /// invalid values before 0 and after -1
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0 || firstArgument == -1)
            {
                throw new Exception("Does't exsist");
            }
            return Math.Log(firstArgument);
        }
    }
}
