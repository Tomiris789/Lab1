using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{


    class Program
    {
        public class Student //создаем класс Студента, который имеет параметры имя, фамилия, возраст и гпа
        {
            public string name;
            public string surname;
            public int age;
            public double Gpa;

            public Student(string name, string surname, int age, double Gpa) //конструктор студент
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
                this.Gpa = Gpa;
            }
            public override string ToString()
            {
                return this.name + " " + this.surname + " " + this.age + " " + this.Gpa;
            }
        }
        public static void Main(string[] args)
        {
            Student Student1 = new Student("Tomiris", "Bolatbekova", 17, 3.0);
            Student Student2 = new Student("Kamilla", "Rinatova", 18, 3.7);
            Console.WriteLine(Student1.ToString());
            Console.WriteLine(Student2.ToString());
            Console.ReadLine();

        }
    }


}

