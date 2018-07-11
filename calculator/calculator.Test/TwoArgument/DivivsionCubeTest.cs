using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class DivisionCubeTest
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
    }
}
