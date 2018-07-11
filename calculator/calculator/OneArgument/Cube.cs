using System;
namespace calculator.OneArgument
{
    public class Cube : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 3);
        }

    }
}
