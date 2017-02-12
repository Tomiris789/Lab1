using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication.Week_I
{
    public class PrimeNumber            //класс Prime number
    {
        public bool IsPrime(int number)     //функция IsPrime, которая проверяет является ли число массива простым
        {
            if (number == 1) return true;  //если число является единицей, то это простое число
            if (number == 2) return true;  //если число является двойкой, то оно простое

            if (number % 2 == 0) return false;   //если число четное, тогда оно не простое и возвращаем false

            for (int i = 2; i < Math.Sqrt(number); i++)  //пробегаемся от двойки до корня числа и если число поделилось на одно из этих цифр, то оно не простое
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        public bool IsPrime2(string number)  //Булеановская функция, переводящее число из строки в инт
        {
            int a = Int32.Parse(number); //меняем число в инт и записываем его в а
            return IsPrime(a); //возвращаем значение а
        }

        public int[] ToIntegerArray(string[] stringArray)       //метод, в котором превращаем элементы массива в инты
        {
            int[] array = new int[stringArray.Length]; //создаем массив интов, длина которого равна длине массива стрингов
            for (int i = 0; i < stringArray.Length; i++)  //пробегаемся по каждому элементу массива стрингов
            {
                array[i] = Int32.Parse(stringArray[i]);  //превращаем значение каждого элемента массива в инт
            }
            return array;  //возвращаем элементы массива в виде интов
        }

        public List<int> ToPrimeNumberArray(int[] numberArray) //лист интов
        {
            List<int> primes = new List<int>();  //проверяем число на простоту и если оно не простое, то добавляем его в лист
            for (int i = 0; i < numberArray.Length; i++) //циклом пробегаемся по массиву 
            {
                if (IsPrime(numberArray[i])) //вызываем функцию IsPrime, которая проверяет число на простоту для каждого числа
                {
                    primes.Add(numberArray[i]); //если число простое, то добавляем число в лист
                }
            }
            return primes; //возвращаем простые числа
        }

        static void Main(string[] args)
        {

            PrimeNumber primeNumber = new PrimeNumber();  //создаем primeNumber класса PrimeNumber

            string[] numbers = FileSystem.F2().Split(); //сплитим массив чисел

            int[] array = primeNumber.ToIntegerArray(numbers); //в новый массив интов записываем элементы массива, 

            List<int> primes = primeNumber.ToPrimeNumberArray(array);

            foreach (var i in primes)
            {
                Console.WriteLine(i); //выводим каждый элемент
            }

            primes.Sort(); //сортируем элементы по возрастанию

            Console.WriteLine($"MIN PRIME NUMBER IS {primes[0]}"); //выводим элемент с нулевым индексом как минимальный элемент массива простых чисел

            Console.ReadLine(); //ждем нажатия пользователем Enter
        }
    }
}
