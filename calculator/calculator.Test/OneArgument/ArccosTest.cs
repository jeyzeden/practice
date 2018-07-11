using System;
using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class ArccosTest
    {
        [TestCase(0, 1.57)]
        [TestCase(0.16, 1.41)]
        [TestCase(1, 0)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Arccos");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
        [TestCase(-1.1)]
        [TestCase(1.1)]
        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Arccos();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}