using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Week_I
{
    public class PrimeNumber
    {
        public bool IsPrime(int number)
        {
            if (number == 1) return true;
            if (number == 2) return true;

           if (number % 2 == 0) return false;   

            for (int i = 2; i < Math.Sqrt(number); i ++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        public bool IsPrime2(string number)
        {
            int a = Int32.Parse(number);
            return IsPrime(a);


        }

        public int[] ToIntegerArray(string[] stringArray)
        {
            int[] array = new int[stringArray.Length];
            for(int i = 0; i<stringArray.Length; i++)
            {
                array[i] = Int32.Parse(stringArray[i]);
            }
            return array;
        }

        public List<int> ToPrimeNumberArray(int[] numberArray)
        {
            List<int> primes = new List<int>();
                for(int i=0; i<numberArray.Length; i++)
            {
                if( IsPrime(numberArray[i]))
                {
                    primes.Add(numberArray[i]);
                }
            }
            return primes;
        }
    }
}


