using NUnit.Framework;
using Lab_05_Selection;

namespace Lab_05_Selection_TEST
{
    public class SelectionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Mark40AndOverPasses()
        //{
        //    var result = Program.PassFail(40);
        //    Assert.AreEqual("Pass", result);
        //}

        //[Test]
        //public void Mark39AndUnderFails()
        //{
        //    var result = Program.PassFail(39);
        //    Assert.AreEqual("Fail", result);
        //}


        //[TestCase(76, "Pass with Distinction")]
        //[TestCase(75, "Pass with Distinction")]
        //public void Mark75AndOverPassesWithDistinction(int mark, string expected)
        //{
        //    var result = Program.PassFail(mark);
        //    Assert.AreEqual(expected, result);
        //}

        //[TestCase(60, "Pass with Merit")]
        //[TestCase(74, "Pass with Merit")]
        //public void MarkBetween60And74PassesWithMerit(int mark, string expected)
        //{
        //    var result = Program.PassFail(mark);
        //    Assert.AreEqual(expected, result);
        //}

        [TestCase(5, "Error")]
        [TestCase(3, "Code Red")]
        [TestCase(2, "Code Amber")]
        [TestCase(1, "Code Amber")]
        [TestCase(0, "Code Green")]
        public void PriorityTest(int level, string expected)
        {
            Assert.AreEqual(expected, Program.Priority(level));
        }
    }
}