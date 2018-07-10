﻿using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgumentTest
{
    [TestFixture]
    public class TangensTest
    {
        [TestCase(0, 0)]
        [TestCase(30, -6.4)]
        [TestCase(5, -3.38)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Tangens");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
