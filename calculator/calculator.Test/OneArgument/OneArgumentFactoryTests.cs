using System;
using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    class OneArgumentFactoryTests
    {
        [TestCase("Cosinus", typeof(Cosinus))]
        [TestCase("Tangens", typeof(Tangens))]
        [TestCase("Arccos", typeof(Arccos))]
        [TestCase("Arcsin", typeof(Arcsin))]
        [TestCase("Arctg", typeof(Arctg))]
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Square", typeof(Square))]
        [TestCase("Cube", typeof(Cube))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Module", typeof(Module))]
        [TestCase("Exp", typeof(Exp))]
        [TestCase("Fraction", typeof(Fraction))]
        [TestCase("TenExp", typeof(TenExp))]
        [TestCase("TwoExp", typeof(TwoExp))]
        public void FirstTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
