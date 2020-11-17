using System;
using System.Diagnostics;

namespace Lab_10_DataTypes2
{
    class Program
    {
        private static readonly string _name = "Dom";
        private static readonly string _name2;

        public Program(string name)
        {
            name = _name2;
        }

        static void Main(string[] args)
        {
            //var tps = TimeSpan.TicksPerSecond;
            //var nowInTicks = DateTime.Now.Ticks;

            //Console.WriteLine(tps.ToString() + nowInTicks.ToString());

            //var d = new DateTime();
            //var d1 = DateTime.Today;
            //var d2 = DateTime.Now;
            //var d3 = new DateTime(1996, 5, 29, 7, 23, 0);

            //var age = d2 - d3;
            //var ageInYears = (int)age.Days / 365.25;

            //Console.WriteLine(ageInYears);

            //var output = d2.ToString("dd/MM/yyyy HH:mm:ss");
            //var output2 = d2.ToString("d-MMM-yy");
            //var output3 = d2.ToString("dddd-dd-MMMM-y");

            //var timespan = new TimeSpan(14, 1, 0, 0);
            //var d4 = new DateTime(1996, 5, 29, 7, 23, 0);
            //var date = d4 + timespan;
            //var date2 = DateTime.Now + timespan;

            //var s = new Stopwatch();

            //s.Start();
            //int total = 0;

            //for (int i = 0; i < 1000; i++)
            //{
            //    total += 1;
            //}

            //s.Stop();

            //Console.WriteLine(s.Elapsed);
            //Console.WriteLine(s.ElapsedMilliseconds);
            //Console.WriteLine(s.ElapsedTicks);
            //Console.ReadLine();

            //Suit theSuit = Suit.HEARTS;
            //var theSuitInt = (int)theSuit;

            //Suit theSuit2 = (Suit)3;
            //Suits(theSuit2);

            //string theSuit3 = ((Suit)0).ToString();

            //var monday = (DayOfWeek)1;
            //Console.WriteLine(monday);

            //int sparta;
            //int? global; //Nullable<int> global;

            //bool? hasPassed;

            //if (hasPassed == true)
            //{
            //    Console.WriteLine($"hasPassed has a value of {hasPassed}");
            //}
            //else
            //{
            //    Console.WriteLine("hasPassed has a value of null");
            //}

            //int totalCost = 0;
            //int price = 1;
            //int? items = null;

            //if (items.HasValue)
            //{
            //    totalCost = items.Value * price;
            //}
            //Console.WriteLine(items.HasValue);
            //Console.WriteLine(totalCost);

            //int? nullableScore = null;
            //int score = nullableScore ?? -9999;
            //int score1 = nullableScore.GetValueOrDefault(-1);
            //int score2 = nullableScore.GetValueOrDefault();

            //Console.WriteLine(_name);
            //const int DOZEN = 12;
            //dynamic item = 100;
            //Console.WriteLine($"adding 10 to {item} gives {item + 10}");

            //item = "Hello";
            //Console.WriteLine($"adding 10 to {item} gives {item + 10}");

            //var rng = new Random();
            //var rngSeeded = new Random(42);
            //var between1And10 = rngSeeded.Next(1, 10);

            //Console.WriteLine(between1And10);

            var rollTheDice = new Random();
            var dice1 = rollTheDice.Next(7);
            var dice2 = rollTheDice.Next(7);
            var dice3 = rollTheDice.Next(7);

            Console.WriteLine($"{dice1} {dice2} {dice3}: {dice1 + dice2 + dice3}");
        }

        public static void Suits(Suit suit)
        {
            switch (suit)
            {
                case(Suit.HEARTS):
                    Console.WriteLine("You have stolen it");
                    break;
                case (Suit.DIAMONDS):
                    Console.WriteLine("Best Friend");
                    break;
                case (Suit.SPADES):
                    Console.WriteLine("Shovel");
                    break;
                case (Suit.CLUBS):
                    Console.WriteLine("Club foot");
                    break;
            }
        }

        public enum Suit
        {
            HEARTS, CLUBS, DIAMONDS, SPADES
        }
    }
}
