﻿namespace calculator.TwoArgument
{
    public class Addition : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
