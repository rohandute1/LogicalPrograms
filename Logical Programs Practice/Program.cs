using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Practice
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Logical programs");
            Console.WriteLine("Please chose the option given below: ");
            Console.WriteLine(" 1.Fibonacci series\n 2.Perfect number\n 3.Prime number checker\n 4.Number Reversing\n 5.Coupon Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Write("Please enter the number: ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.PrintFibonacciSeries(N);
                    break;

                case 2:
                    Console.WriteLine("Please enter the number: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber.CheckingPerfectNumber(n);
                    break;
                case 3:
                    Console.WriteLine("Enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.PrimeNumberChecker(number);
                    break;

                case 4:
                    Console.WriteLine("Enter a number: ");
                    int X = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.Main(X);
                    break;
                case 5:
                    int coupon = 10; // Number of distinct coupon numbers
                    int totalRandomNumbers = CouponNumbers.GenerateDistinctCoupons(coupon);
                    Console.WriteLine($"Total random numbers needed to have all distinct numbers: {totalRandomNumbers}");
                    break;
            }
            Console.ReadLine();
        }
    }
}
