using calculator.TwoArgument;
using NUnit.Framework;
using System;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class DivisionSquareTests
    {
        [TestCase(1, 3, 0.11)]
        [TestCase(2, 3, 0.44)]
        [TestCase(4, 2, 4)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("DivisionSquare");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
        [TestCase(0)]
        [TestCase(10)]
        public void ExceptionLessThanZeroTest(double firstArgument, double secondArgument)
        {
            var calculator = new Division();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument, secondArgument));
        }
    }
}
