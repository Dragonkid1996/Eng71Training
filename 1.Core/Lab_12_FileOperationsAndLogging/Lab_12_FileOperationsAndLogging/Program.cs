using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Xceed.Words.NET;

namespace Lab_12_FileOperationsAndLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////File Operations////////

            //string path1 = Directory.GetCurrentDirectory();
            //string path2 = Path.GetFullPath(Path.Combine(path1, @"..\..\..\\Lyrics\"));

            //string lyrics = File.ReadAllText(path2 + "/Wonderwall.txt");
            //Console.WriteLine(lyrics);

            //File.WriteAllText(path2 + "ChampagneSupernova.txt", "In Champagne Supernova in the sky");

            //string[] lyrics = { "So", "Sally", "Can", "Wait" };
            //File.WriteAllLines(path2 + "/DontLookBackInAnger.txt", lyrics);

            //var path3 = path2 + @"\myLyrics.txt";
            //if (!File.Exists(path3))
            //{
            //    string[] createText = { "Hello", "I'm", "Dom" };
            //    File.WriteAllLines(path3, createText);
            //}

            //string[] readText = File.ReadAllLines(path3);

            //foreach (var item in readText)
            //{
            //    Console.WriteLine(item);
            //}

            //string appendText = "And I got a new haircut"/* + Environment.NewLine*/;
            //File.AppendAllText(path3, appendText);

            //File.WriteAllText(path2 + @"/oldLyrics.txt", "Hey now, I'm an All Star");

            //string oldLyrics = path2 + @"/oldLyrics.txt";
            //string newLyrics = path2 + @"/newLyrics.txt";

            ////Copy oldLyrics into newLyrics, don't overwrite if it already exists
            //File.Copy(oldLyrics, newLyrics, false);

            //File.Delete(path2 + @"/oldLyrics.txt");

            //DateTime lastWriteTime = File.GetLastWriteTime(path3);
            //DateTime creationTime = File.GetCreationTime(path3);
            //var fileInfo = new FileInfo(path3);  

            //Console.WriteLine("Last write time: " + lastWriteTime + " Creation Time: " + creationTime);
            //Console.WriteLine(fileInfo.DirectoryName, fileInfo.Extension);


            ////////Folder Operations////////

            //var fileArray = Directory.GetFiles(path2);

            //foreach (var item in fileArray)
            //{
            //    Console.WriteLine(item);
            //}

            //Directory.CreateDirectory(path2 + "FolderA");
            //Directory.Delete(path2 + "FolderA");


            ////////Logging////////

            //Log to VS output window

            //int total = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //    total += 1;
            //    Debug.WriteLine($"Debug - The value of i is {i}");
            //    Trace.WriteLine($"Trace - The value of i is {i}");
            //}

            ////////Conditional Compilation

            //            Console.WriteLine("Starting app");
            //#if DEBUG
            //            Console.WriteLine("This is debug mode);
            //#endif
            //            Console.WriteLine("Finishing app");


        }
    }
}
