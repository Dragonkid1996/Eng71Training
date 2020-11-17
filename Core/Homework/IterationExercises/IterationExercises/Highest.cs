using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int i = 0, high = int.MinValue;
            while (i < nums.Length)
            {
                if (nums[i] > high)
                {
                    high = nums[i];
                }
                i++;
            }
            return high;
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            int high = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > high)
                {
                    high = nums[i];
                }
            }
            return high;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            int high = int.MinValue;
            foreach (var item in nums)
            {
                if (item > high)
                {
                    high = item;
                }
            }
            return high;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            int i = 0, high = int.MinValue;
            do
            {
                if (nums[i] > high)
                {
                    high = nums[i];
                }
                i++;
            } while (i < nums.Length);
            return high;
        }
    }
}