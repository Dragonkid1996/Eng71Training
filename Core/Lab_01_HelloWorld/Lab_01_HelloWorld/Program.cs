using System;

namespace Lab_01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 100;
            //x += 10;

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("Hello, Command Line Demo");

            foreach (string item in args)
            {
                Console.WriteLine($"{ item } is on Eng71");
            }
        }
    }
}
