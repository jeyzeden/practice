using calculator.TwoArgument;
using NUnit.Framework;
using System;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class DivisionCubeTests
    {
        [TestCase(1, 3, 0.03)]
        [TestCase(2, 3, 0.29)]
        [TestCase(4, 2, 8)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("DivisionCube");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestCase(10, 0 )]
        public void ExceptionLessThanZeroTest(double firstArgument, double secondArgument)
        {
            var calculator = new Division();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument, secondArgument));
        }
    }
}
