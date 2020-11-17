using System;

namespace Lab_05_Selection
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Priority(3)); 
            //int days = 4;

            //switch (days)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    default:
            //        Console.WriteLine("Weekend");
            //        break;
            //}

            int mark = 30;

            int x = mark > 60 ? 1 : 2; 
        }

        //public static string PassFail(int mark)
        //{
        //    var grade = "Fail";

        //    if (mark >= 40)
        //    {   
        //        grade = "Pass";

        //        if (mark >= 75)
        //        {
        //            grade += " with Distinction";
        //        }
        //        else if (mark >= 60)
        //        {
        //            grade += " with Merit";
        //        }                
        //    }

        //    return grade;
        //}

        //public static string Priority(int level)
        //{
        //    string priority = "Code ";
        //    switch (level)
        //    {
        //        case 3:
        //            priority += "Red";
        //            break;
        //        case 2:
        //        case 1:
        //            priority += "Amber";
        //            break;
        //        case 0:
        //            priority += "Green";
        //            break;
        //        default:
        //            priority = "Error";
        //            break;                
        //    }
        //    return priority;
        //}

        public static string PassFailTernary(int mark)
        {
            return mark > 40 ? "Pass" : "Fail";
        }


    }
}
