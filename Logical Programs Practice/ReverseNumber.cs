using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Practice
{
    internal class ReverseNumber
    {
        public static void Main(int number)
        {
            int reversedNumber = Reverse(number);

            Console.WriteLine($"Reversed number: {reversedNumber}");

            Console.ReadLine();
        }
        public static int Reverse(int number)
        {
            int reversedNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                number /= 10;
            }

            return reversedNumber;
        }
    }
}
