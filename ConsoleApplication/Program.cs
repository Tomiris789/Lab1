using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Week_I;
using ConsoleApplication.Week_II;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            PrimeNumber primeNumber = new PrimeNumber();

            string[] numbers = FileSystem.F2().Split();

            int [] array = primeNumber.ToIntegerArray(numbers);

            List<int> primes = primeNumber.ToPrimeNumberArray(array);

            foreach (var i in primes)
            {
                Console.WriteLine(i);
            }

            primes.Sort();

            Console.WriteLine($"MIN PRIME NUMBER IS {primes[0]}");

            Console.ReadLine();
        }
    }
}
