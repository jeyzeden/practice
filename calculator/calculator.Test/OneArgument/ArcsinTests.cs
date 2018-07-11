using calculator.OneArgument;
using NUnit.Framework;
using System;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class ArcsinTests
    {
        [TestCase(0, 0)]
        [TestCase(0.5, 0.52)]
        [TestCase(1, 1.57)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Arcsin");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
        [TestCase(-1.1)]
        [TestCase(1.1)]
        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Arcsin();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}