using System.Collections.Generic;
using System.Text;

namespace CollectionsExercises
{
    public class CollectionExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < num; i++)
            {
                try
                {
                    sb.Append(queue.Dequeue());
                    sb.Append(", ");
                }
                catch (System.Exception)
                {
                    continue;
                }                    
            }
            if(sb.Length != 0)
                sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            //var stackReverse = new Stack<int>();
            //foreach (var item in original)
            //{
            //    stackReverse.Push(item);
            //}
            //int[] reversed = new int[stackReverse.Count];
            //for (int i = 0; i < stackReverse.Count; i++)
            //{
            //    reversed[i] = stackReverse.Pop();
            //}
            //return reversed;

            var l = new List<int>(original);
            l.Reverse();
            return l.ToArray();

        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var counter = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();
            foreach (var item in input)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item, 1);
                }
            }
            foreach (var item in counter)
            {
                if(char.IsDigit(item.Key))
                {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }
    }
}