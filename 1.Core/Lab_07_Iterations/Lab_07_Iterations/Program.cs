using System;

namespace Lab_07_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] myArray = { 10, 20, 30 };

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //foreach (var item in myArray)
            //{
            //    Console.WriteLine(item);
            //}

            //int counter = 0;

            //while (counter <= 10)
            //{
            //    Console.WriteLine(counter * 10);
            //    counter++;
            //}

            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter <= 10);

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //string king = "DOM IS KING".ToLower();

            //foreach (var item in king)
            //{
            //    Console.WriteLine(item);
            //}

            //int i = 0;            
            //while(i < 10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //}

            //int counter = 0;
            //while (counter < 10)
            //{
            //    counter++;
            //    Console.WriteLine(counter);

            //    if (counter < 4) continue;
            //    Console.WriteLine(counter * 4);
            //}

            //for (int i = 0, a = 4; i < 10 && a > 0; i++, a--)
            //{
            //    Console.WriteLine(a, i);
            //}

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0)
                {
                    break;
                }
            }
        }
    }
}
