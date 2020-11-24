using System;
using System.Collections.Generic;

namespace CollectionsExercises
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var multiplesOf5 = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    multiplesOf5.Add(i);
                }
            }
            return multiplesOf5;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            if (argList.Count == 0)
                return 0;
            double sum = 0;
            foreach (var item in argList)
            {
                sum += item;
            }
            return sum / argList.Count;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var a = new List<string>();
            foreach (var item in sourceList)
            {
                if(item[0] == 'a' || item[0] == 'A')
                {
                    a.Add(item);
                }
            }
            return a; 
        }
    }
}
  