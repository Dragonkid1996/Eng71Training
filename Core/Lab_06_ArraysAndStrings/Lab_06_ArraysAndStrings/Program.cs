using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] charArray = { 'H', 'e', 'l', 'l', 'o' };

            //var charArray2 = new char[] {'H', 'e', 'l', 'l', 'o'};

            //var c = charArray2[0];

            //char[] charArray3 = new char[5];

            //charArray3[2] = 'l';

            //int[,] grid = new int[2, 4];

            //grid[0, 1] = 2;

            //int[,] array2 = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            //int[,,,] grid4d = new int[3, 4, 20, 20];

            //string[][] Eng71 = new string[][]
            //{
            //    new string[] { "Kishan", "Breesha", "Beanca", "Leonard" },
            //    new string[] { "Dom", "Greg", "Mansib", "Ayo" }
            //};

            //var eng = Eng71[0][0];

            //char[][] city = new char[5][];
            //city[0] = new char[4];
            //city[1] = new char[10];
            //city[2] = new char[20];
            //city[3] = new char[30];
            //city[4] = new char[10];

            //city[0][0] = 'B';
            //city[0][1] = 'a';
            //city[0][2] = 't';
            //city[0][3] = 'h';

            //string cityname = $"{city[0][0]}{city[0][1]}{city[0][2]}{city[0][3]}";
            //foreach (var item in city[0])
            //{
            //    cityname += city[0][item];
            //}

            //List<string> theBeatles = new List<string> { "John Lennon", "Ringo Starr"};

            //theBeatles.Add("George Harrison");
            //theBeatles.Add("Paul McCartney");

            //var eng71 = new List<string> { "Lauren", "Gino" };

            //Strings
            //string name = "Gregory";
            //char initial = name[0];

            //int length = name.Length;

            //var upperCase = name.ToUpper();

            //var spaceName = "         Breesha       ";
            //var trimmedName = spaceName.Trim();

            //string fname = "Dom";
            //string lname = "Newell";

            //var string1 = $"{fname} {lname}";
            //var string2 = fname + " " + lname;

            //var score = 0.85;
            //var string3 = $"{fname} {lname}, Age: {score:p2}";

            //Console.WriteLine("How many apples?");
            //string input = Console.ReadLine();

            //input = "66";

            //int numApples = int.Parse(input);

            //string input2 = "128";

            //bool success = int.TryParse(input2, out int numApples);

            //if(success)
            //{
            //    Console.WriteLine(numApples);
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("World");
            sb.AppendLine("And Dom");

            string dom = sb.ToString();

            Console.WriteLine(sb);

            sb.Remove(4, 1);

            sb.Replace('d', 'N');

        }
    }
}
