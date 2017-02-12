using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student             //создаем класс Студент с параметрами имя, фамилия и гпа
    {
        public string name;  
        public string surname;
        public double gpa;  

        public Student()     //конструктор Студент без параметров
        {
            name = "Tomiris";    //с начальными значениями
            surname = "Bolatbekova";
            gpa = 4.0;
        } 
        public Student(string name, string surname, double gpa)  //конструктор Студент с тремя параметрами
        {
            this.name = name;  //
            this.surname = surname;
            this.gpa = gpa;
        }
        public override string ToString()    //переписываем значения в стринг
        {
            return name + " " + surname +  " " + gpa;

        }
    }
    //override - переписывание метода одинаковое по названию
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();  //создаем нового студента, выделяем память

            Console.WriteLine("Please, enter data in following format: Name Surname GPA"); //инструкции пользователю
            string inputLine = Console.ReadLine();  //вводим данные 
            string[] vals = inputLine.Split(' '); //если в линии пробелы, то создаем массив из элементов строки

            student1.name = vals[0]; //первый элемент массива - имя студента
            student1.surname = vals[1]; //второй элемент - фамилия

            student1.gpa = Convert.ToDouble(vals[2]); //меняем гпа из string в double
             
            Console.WriteLine(student1.ToString()); //выводим данные студента
            Console.ReadKey();
        }
    }
}
