using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class OneArgumentFactory
    {
        public static IOneArgumentFactory CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Cosinus":
                    return new Cosinus();
                case "Sinus":
                    return new Sinus();
                case "Square":
                    return new Square();
                case "Module":
                    return new Module();
                case "Tangens":
                    return new Tangens();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
