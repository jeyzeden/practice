﻿using System;

namespace calculator.OneArgument
{
    public class Ln : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Does't exsist");
            }
            return Math.Log(firstArgument);
        }
    }
}