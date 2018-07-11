using System;
using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.Factory
{
    class TwoArgumentFactoryTest
    {
        [TestCase("Addition", typeof(Addition))]
        [TestCase("Multiply", typeof(Multiply))]
        public void FirstTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
