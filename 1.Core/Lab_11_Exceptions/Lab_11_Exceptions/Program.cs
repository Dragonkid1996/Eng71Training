using System;
using System.IO;

namespace Lab_11_Exceptions
{
    public class Program
    {
        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };
        
        public static void ChangeBeatles(int pos, string name)
        {
            if(pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException($"Another Beatle cannot be added");
            }

            _theBeatles[pos] = name;
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    ChangeBeatles(4, "Brian");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Exception Thrown: " + ex.Message);
            //}


            //try
            //{
            //    _theBeatles[4] = "Brian";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("1. Sorry no 5th Beatle");

            //    throw;
            //    //Console.WriteLine($"2. {ex.ToString()};");
            //    //Console.WriteLine($"3. {ex.Message};");
            //    //Console.WriteLine($"4. {ex.Data};");

            //    //foreach (var item in ex.Data)
            //    //{
            //    //    Console.WriteLine(item);
            //    //}
            //}

            //int x = 10;
            //int y = 0;

            //try
            //{
            //    int output = x / y;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("An Exception has occurred");
            //}
            //finally
            //{
            //    Console.WriteLine("But life goes on");
            //}

            //try
            //{
            //    File.OpenRead("tryEx.txt");
            //}
            //catch (DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine("Could not find tryEx diectory");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Could not find the tryEx.txt file");
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Problem reading file");
            //}
            checked
            {
                int three = 3;
                int max = int.MaxValue;
                Console.WriteLine(max + three);
            }
            
        }
    }
}
