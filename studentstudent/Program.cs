using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        public string name; //""
        public string surname;
        public double gpa; // 0.00 int 0

        public Student()
        {
            name = "Tomiris";
            surname = "Bolatbekova";
            gpa = 4.0;
        }
        public Student(string name, string surname, double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return name + " " + surname +  " " + gpa;

        }
    }
    //override - переписывание метода одинаковое по названию
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            Console.WriteLine("Please, enter data in following format: Name Surname GPA");
            string inputLine = Console.ReadLine();
            string[] vals = inputLine.Split(' ');

            student1.name = vals[0];
            student1.surname = vals[1];

            Console.WriteLine(vals[2]);
            student1.gpa = Convert.ToDouble(vals[2]);

            Console.WriteLine(student1.ToString());
            Console.ReadKey();
        }
    }
}

