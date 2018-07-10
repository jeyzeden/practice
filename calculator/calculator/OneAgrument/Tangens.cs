using System;
namespace calculator
{
    public class Tangens : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);

        }

    }
}
