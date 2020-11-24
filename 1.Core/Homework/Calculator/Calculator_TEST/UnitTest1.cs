using NUnit.Framework;
using Calculator;
using System;

namespace Calculator_TEST
{
    public class StaticCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 3, 4)]
        [TestCase(20, 20, 40)]
        [TestCase(1200, 3, 1203)]
        [TestCase(-8, -2, -10)]
        [TestCase(0, 0, 0)]

        public void AddTest(double num1, double num2, double expected)
        {
            var actual = CalculatorMethod.Add(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3, -2)]
        [TestCase(20, 20, 0)]
        [TestCase(13, -6, 19)]
        [TestCase(8701, 6500, 2201)]
        [TestCase(0, 0, 0)]
        public void SubtractTest(double num1, double num2, double expected)
        {
            var actual = CalculatorMethod.Subtract(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3, 3)]
        [TestCase(20, 20, 400)]
        [TestCase(9, 16, 144)]
        [TestCase(33, 3, 99)]
        [TestCase(0, 0, 0)]
        public void MultiplyTest(double num1, double num2, double expected)
        {
            var actual = CalculatorMethod.Multiply(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 3, 3)]
        [TestCase(20, 20, 1)]
        [TestCase(30, 3, 10)]
        [TestCase(88, 4, 22)]
        [TestCase(1, 1, 1)]
        public void DivideTest(double num1, double num2, double expected)
        {
            var actual = CalculatorMethod.Divide(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 3, 0)]
        [TestCase(20, 16, 4)]
        [TestCase(80, 7, 3)]
        [TestCase(16, 3, 1)]
        [TestCase(1, 1, 0)]
        public void ModulusTest(double num1, double num2, double expected)
        {
            var actual = CalculatorMethod.Modulus(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividingByZeroThrowsAnException()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => CalculatorMethod.Divide(20, 0));
            Assert.AreEqual("Cannot divide by Zero", ex.Message, "Exception messages do not match");
        }
    }
}