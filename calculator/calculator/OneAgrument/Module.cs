﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Module : IOneArgumentFactory
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);

        }

    }
}
