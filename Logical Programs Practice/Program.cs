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
            Console.Write("Please enter the number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries fibonacci = new FibonacciSeries();
            FibonacciSeries.PrintFibonacciSeries(N);
            Console.ReadLine();
        }
    }
}
