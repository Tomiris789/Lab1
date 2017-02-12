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
        public static string F2()
        {
            FileStream fs = new FileStream(@"input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();

            

            sr.Close();
            fs.Close();

            return text;
        }
    }
}
