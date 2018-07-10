using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
