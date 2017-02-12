using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Week_II
{
    public static class FileSystem  //класс FileSystem
    {
        public static string F2()   
        {
            FileStream fs = new FileStream(@"input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); //FileStream используется для операции чтения и записи в файл, открытия и закрытия файлов в файловой системе
            //FileMode- определяет способ открыти или создания файла; FileAccess- определяет каким образом FileStream может получить доступ к файлу
            StreamReader sr = new StreamReader(fs); //StreamReader- считывает символы из потока байтов в определенной кодировке

            string text = sr.ReadToEnd();  //строка text считывает файл. ReadToEnd-считывает все символы начиная с текущей позиции до конца потока

            

            sr.Close();  //закрывает объект StreamReader 
            fs.Close();   //закрывает текущий поток

            return text; //возвращаем данные с файла
        }
    }
}
