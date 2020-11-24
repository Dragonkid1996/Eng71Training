using System;

namespace Lab_04_MethodsAndTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var myTuple = (fname: "Nish", lname: "Mandal", 30);
            //(string, string, int) myTuple2 = ("Sparta", "Global", 2);

            //Console.WriteLine(myTuple2);
            //Console.WriteLine(myTuple.fname);

            //var movie = "Notting Hill";
            //int views = 1;

            //var myTuple3 = (movie, views);

            //var result = TupleExample(10, "here's a string");
            //Console.WriteLine(result);

            //Console.WriteLine(result.isLarge);

            //var (square, greatThan10) = TupleExample(25, "Hello");
            //Console.WriteLine(greatThan10);

            //Console.WriteLine(Add(1, 2));
            //Console.WriteLine(Add(1, 2, 3));

            var result = TripleCalc(2, 3, 4, out int sum);
            Console.WriteLine(result.ToString() + ' ' + sum.ToString());

            var result2 = TripleCalc(2, 3, 4);
            Console.WriteLine(result2.product.ToString() + ' ' + result2.sum.ToString());
        }

        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        public static (int sum, int product) TripleCalc(int a, int b, int c)
        {
            int sum = a + b + c;
            int product = a * b * c;
            return (sum, product);
        }

        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //public static int Add(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //public static (int xsquared, bool isLarge) TupleExample(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x * x, z);
        //}

        //public static int OutKeyword(int x, string y, out bool z)
        //{
        //    Console.WriteLine(y);
        //    z = (x > 10);
        //    return x * x;
        //}

        //static void Add(int number)
        //{
        //    number++;
        //}

        //static void Add(ref int number) //Don't use this
        //{
        //    number++;
        //}

        //static void OrderPizza(bool anchovies, bool pineapple, bool mushroom = false)
        //{   }

        //public static int DoThatAgain(int x, string y = "Default", int z = 1)
        //{
        //    Console.WriteLine(y);
        //    return x * x;
        //}

        //public static int DoThat()
        //{
        //    Console.WriteLine("I am returning 100");
        //    return 100;
        //}

        //public static void DoThis()
        //{
        //    Console.WriteLine("I am doing something");
        //}
    }
}
