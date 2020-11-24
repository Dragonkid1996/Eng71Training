using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndStructs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle(5, 10);
            v.NumPassengers = 7;
            Console.WriteLine(v.NumPassengers);
        }
    }
}