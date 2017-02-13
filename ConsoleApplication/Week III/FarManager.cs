using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAR
{
    class Program
    {
        class CustomFolderInfo         //Custom folders are special folders that represent the on the target computer 
        {
            CustomFolderInfo prev; //предыдущая папка, где был курсор        
            int index; // индекс курсора 
            DirectoryInfo[] dirs;  //DirectoryInfo - предоставляет методы экземпляра класса для создания, перемещения и перечисления в каталогах и подкаталогах

            public CustomFolderInfo(CustomFolderInfo prev, int index, DirectoryInfo[] directoryInfo) //конструктор с параметрами предыдущая папка, индекс текущей папки и информация а каталогах
            {
                this.prev = prev;             
                this.index = index;
                this.dirs = directoryInfo;
            }
            public void PrintFolderInfo()  //метод для отображения списка подкаталогов и смены цвета папки с текущий индексом
            {
                Console.Clear();    //удаляем список папок

                for (int i = 0; i < dirs.Length; ++i) //пробегаемся  циклом от начала до окончания списка папок
                {
                     if (i == index) //если индекс текущий папки совпадает с индексом, по котором курсором водит пользователь, то название папки отображается зеленым
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White; //в противном случае, название остается белым
                    }
                    Console.WriteLine(dirs[i]); //выводим на экран список папок
                }
            }

            public void DecreaseIndex() //метод для перемещения курсора вверх, индекс уменьшается
            {
                if (index - 1 >= 0) index--;     //если идем наверх, то индекс уменьшается
                  else index = dirs.Length - 1;  //если индекс был нулевым и мы нажимаем курсор вверх, то возвращаемся в конец списка папок
            }

            public void IncreaseIndex()  //метод для перемещения курсора вниз, индекс растет
            {
                if (index + 1 < dirs.Length) index++;  //если индекс меньше длины массива, то когда нажимаем вниз, индекс возрастает
                else index = dirs.Length-index;
            }

            public CustomFolderInfo GetNextItem()  //метод, позволяющий получать папки в папках
            {
                return new CustomFolderInfo(this, 0, this.dirs[index].GetDirectories());
            }

            public CustomFolderInfo GetPrevItem() //метод для предыдущего элемента
            {
                return prev;
            }
        }

        static void ShowFolderInfo(CustomFolderInfo item)  //ShowFolderInfo - метод, показывающий информацию о папках
        {
            item.PrintFolderInfo();      //item - текущая позиция курсора. Каждый раз вызываем функцию PrintFolderinfo

            ConsoleKeyInfo pressedKey = Console.ReadKey();  //считывает нажатые клавиши

            if (pressedKey.Key == ConsoleKey.UpArrow)  //если пользователь нажал вверх, то текущий индекс уменьшается 
            {
                item.DecreaseIndex();
                ShowFolderInfo(item);    //снова вызываем этот метод для папки с текущий индексом
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                item.IncreaseIndex();        //если пользователь нажал вниз, то индекс возрастае, снова вызываем метод ShowFolderInfo рекурсивно
                ShowFolderInfo(item);
            }
            else if (pressedKey.Key == ConsoleKey.Enter) //если пользователь нажал Enter, то создаем новый item и переходим к его папкам(переходим к след элементам
            {
                CustomFolderInfo newItem = item.GetNextItem();
                ShowFolderInfo(newItem);  //вызываем метод, показывающий списов папок
            }
            else if (pressedKey.Key == ConsoleKey.Escape)  //если пользователь ввел Escape, то возвращаемся к предыдущему списку
            {
                CustomFolderInfo newItem = item.GetPrevItem();
                ShowFolderInfo(newItem);
            }
        } 

        static void Main(string[] args)
        {
            CustomFolderInfo test = new CustomFolderInfo(null,0,new DirectoryInfo(@"C:\").GetDirectories()); //изначально список папок пуст, 0 индекс, отображаем папки с методом GetDirectories, который показывает все папки 
            Console.CursorVisible = false; //сделать курсор невидимым)
            ShowFolderInfo(test);

           DirectoryInfo dr = new DirectoryInfo("C:\\Python27"); //отображает файлы в папке питон
           FileSystemInfo[] list = dr.GetFileSystemInfos(); //GetFileSystemInfos - отображает не только папки, но и файлы. Файлы записаны в листе

                     for (int i = 0; i < list.Length; i++)
                         Console.WriteLine(list[i]);
                   Console.ReadKey();
        }
    }
}
