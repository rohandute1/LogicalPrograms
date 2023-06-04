using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Practice
{
    internal class PrimeNumber
    {
        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void PrimeNumberChecker(int number) 
        {
            

            bool isPrime = IsPrimeNumber(number);

            if (isPrime) 
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
            Console.ReadLine();
        }
       
    }
}
