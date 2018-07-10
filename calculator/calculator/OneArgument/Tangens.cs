using System;
namespace calculator.OneArgument
{
    public class Tangens : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);

        }

    }
}
