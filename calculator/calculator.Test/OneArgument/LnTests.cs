using calculator.OneArgument;
using NUnit.Framework;
using System;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(5, 1.60)]
        [TestCase(1, 0)]
        [TestCase(10, 2.30)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Ln");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
        [TestCase(-1)]
        [TestCase(0)]
        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Ln();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}