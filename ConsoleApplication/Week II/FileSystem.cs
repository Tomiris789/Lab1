using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Week_II
{
    public static class FileSystem
    {
        public static void F5()
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Escape!");
            }
            else if (pressedKey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Enter!");
            }
            else if (pressedKey.Key == ConsoleKey.A)
            {
                Console.WriteLine("A!");
            }
        }

        public static void F4()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Books");

            foreach (FileSystemInfo x in dir.GetFileSystemInfos())
            {
                Console.WriteLine(x.Name);
            }
        }

        public static void F3()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Books");
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Console.WriteLine(d.Name);
            }

            foreach (FileInfo f in dir.GetFiles())
            {
                Console.WriteLine(f.Name);
            }
        }

        public static string F2()
        {
            FileStream fs = new FileStream(@"input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();

            

            sr.Close();
            fs.Close();

            return text;
        }

        public static void F1()
        {
            FileStream fs = new FileStream(@"D:\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hello world!");

            sw.Close();
            fs.Close();
        }

        public static void RecursivelyDirectoryShow(string directory = @"D:\Books")
        {
            foreach (string d in Directory.GetDirectories(directory))
            {
                foreach (string f in Directory.GetFiles(d))
                {
                    Console.WriteLine(f);
                }
                RecursivelyDirectoryShow(d);
            }
        }
    }
}
