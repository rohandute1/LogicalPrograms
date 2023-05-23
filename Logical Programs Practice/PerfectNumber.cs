using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Practice
{
    internal class PerfectNumber
    {
        public static void CheckingPerfectNumber(int n)
        {

            bool isPerfect = IsPerfectNumber(n);

            if (isPerfect) 
            {
                Console.WriteLine($"It is a prfect numnber", + n); 
            }
            else 
            {
                Console.WriteLine($"It is not a prfect numnber", +n);
            }
            Console.ReadLine();
        }
        public static bool IsPerfectNumber(int number) 
        {
            int sum = 0;
            for (int i = 1; i < number; i++) 
            {
                if (number % i == 0) 
                {
                    sum += i;
                }
            }
            return sum == number;
        }    

    }
}
