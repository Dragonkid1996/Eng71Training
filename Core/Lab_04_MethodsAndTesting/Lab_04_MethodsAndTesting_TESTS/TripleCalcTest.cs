using NUnit.Framework;
using Lab_04_MethodsAndTesting;

namespace Lab_04_MethodsAndTesting_TESTS
{
    public class TripleCalcTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [TestCase(10,2,3,60)]
        [TestCase(0,-3,7,0)]
        [TestCase(200, 14, 2, 5600)]
        [TestCase(13, 6, 4, 312)]

        [Test]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            //arrange and act
            var actual = Program.TripleCalc(a, b, c, out int sum);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 2, 4, 16)]
        [TestCase(0, -3, 7, 4)]
        [TestCase(200, 14, 2, 216)]
        [TestCase(13, 6, 4, 23)]

        [Test]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            Program.TripleCalc(a, b, c, out int sum);

            Assert.AreEqual(expected, sum);
        }
    }
}