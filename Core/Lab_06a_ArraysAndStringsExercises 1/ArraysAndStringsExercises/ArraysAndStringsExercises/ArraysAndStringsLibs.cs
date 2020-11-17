
using System;
using System.Text;

namespace ArraysAndStringsLib
{
    public class Exercises
    {
        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double percent = ((double)score / (double)outOf) * 100;
            double rounded = Math.Round(percent, 1);
            return $"You got {score} out of {outOf}: {rounded}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            try
            {
                return Convert.ToDouble(numString);
            }
            catch (System.FormatException)
            {
                return -999;
            }
        }
        public static string ManipulateString(string input, int num)
        {
            //var output = input.Trim().ToUpper();
            //for (int i = 0; i < num; i++)
            //{
            //    output += i;
            //}
            //return output;

            StringBuilder output = new StringBuilder();
            output.Append(input.Trim().ToUpper());
            for (int i = 0; i < num; i++)
            {
                output.Append(i);
            }

            return output.ToString();
        }
    }
}