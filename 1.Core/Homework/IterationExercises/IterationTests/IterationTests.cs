using NUnit.Framework;
using IterationLib;

namespace IterationTests
{
    public class IterationTests
    {
        /**  Implement the static methods in IterationLib.Highest class so that they
         * pass the following tests.  Each method should use a different type of loop as indicated:
         * while, for, foreach and do while.
         * 
         * Add more tests for each method.  What happens when the array is empty?
         * When the array contains only negative numbers?  When all the array elements are the same?
         * 
         * You will find one of the loops will not not be suitable in all cases.  Which is it? 
         * You don't need to find a devious way to make it pass - just note that it is not a suitable for this problem.
         **/


        [TestCase(new int[] {10, 6, 22, 17, 3}, 22)]
        [TestCase(new int[] { -4, -2, -12, -17, -3 }, -2)]
        [TestCase(new int[] { 8, 8, 8, 8, 8 }, 8)]
        [TestCase(new int[] { }, int.MinValue)]
        public void HighestWhileLoopTest(int[] nums, int expected)
        {
            var result = Highest.HighestWhileLoop(nums);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 10, 6, 22, 17, 3 }, 22)]
        [TestCase(new int[] { -4, -2, -12, -17, -3 }, -2)]
        [TestCase(new int[] { 8, 8, 8, 8, 8 }, 8)]
        [TestCase(new int[] { }, int.MinValue)]
        public void HighestForLoopTest(int[] nums, int expected)
        {
            var result = Highest.HighestForLoop(nums);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 10, 6, 22, 17, 3 }, 22)]
        [TestCase(new int[] { -4, -2, -12, -17, -3 }, -2)]
        [TestCase(new int[] { 8, 8, 8, 8, 8 }, 8)]
        [TestCase(new int[] { }, int.MinValue)]
        public void HighestForEachLoopTest(int[] nums, int expected)
        {
            var result = Highest.HighestForEachLoop(nums);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 10, 6, 22, 17, 3 }, 22)]
        [TestCase(new int[] { -4, -2, -12, -17, -3 }, -2)]
        [TestCase(new int[] { 8, 8, 8, 8, 8 }, 8)]
        [TestCase(new int[] { }, int.MinValue)]
        public void HighestDoWhileLoopTest(int[] nums, int expected)
        {
            var result = Highest.HighestDoWhileLoop(nums);
            Assert.AreEqual(expected, result);
        }
    }
}