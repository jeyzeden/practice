using System;
using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.TwoArgument
{
    class TwoArgumentFactoryTests
    {
        [TestCase("Addition", typeof(Addition))]
        [TestCase("Multiply", typeof(Multiply))]
        [TestCase("AdditionCube", typeof(AdditionCube))]
        [TestCase("MultiplyCube", typeof(MultiplyCube))]
        [TestCase("AdditionSquare", typeof(AdditionSquare))]
        [TestCase("MultiplySquare", typeof(MultiplySquare))]
        [TestCase("Division", typeof(Division))]
        [TestCase("DivisionCube", typeof(DivisionCube))]
        [TestCase("DivisionSquare", typeof(DivisionSquare))]
        [TestCase("Min", typeof(Min))]
        [TestCase("Max", typeof(Max))]
        [TestCase("Substraction", typeof(Substraction))]
        [TestCase("SubstractionSquare", typeof(SubstractionSquare))]
        [TestCase("Pow", typeof(Pow))]
        public void FirstTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
