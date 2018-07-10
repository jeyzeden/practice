﻿namespace calculator
{
    public class DivisionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
