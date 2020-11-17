using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            try
            {
                int small = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {                
                    if (nums[i] < small)
                    {
                        small = nums[i];
                    }
                }
                return small;
            }
            catch (IndexOutOfRangeException)
            {
                return int.MaxValue;
            }
            
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            };
            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int aTot = 0, bTot = 0, cTot = 0, dTot = 0;
            foreach (var item in input)
            {
                switch (item)
                {
                    case 'A':
                        aTot += 1;
                        break;
                    case 'B':
                        bTot += 1;
                        break;
                    case 'C':
                        cTot += 1;
                        break;
                    case 'D':
                        dTot += 1;
                        break;
                    default:
                        break;
                }
            }            
            return $"A:{aTot} B:{bTot} C:{cTot} D:{dTot}";
        }
    }
}