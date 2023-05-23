using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programs");
            Console.WriteLine("Please chose the option given below: ");
            Console.WriteLine(" 1.Fibonacci series\n 2.Perfect number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Write("Please enter the number: ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    FibonacciSeries.PrintFibonacciSeries(N);
                    break;

                case 2:
                    Console.WriteLine("Please enter the number: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber perfect = new PerfectNumber();
                    PerfectNumber.CheckingPerfectNumber(n);
                    break;
            }
               

            
            Console.ReadLine();
        }
    }
}
