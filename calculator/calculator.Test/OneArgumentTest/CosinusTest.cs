using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgumentTest
{
    [TestFixture]
    public class CosinusTest
    {
        [TestCase(0, 1)]
        [TestCase(3.14, -0.99)]
        [TestCase(5, 0.28)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Cosinus");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}