using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Practice
{
    internal class FibonacciSeries
    {
        public static void PrintFibonacciSeries(int n)
        {
            Console.WriteLine("Fibonacci Series");
            int numb1 = 0, numb2 = 1, sum = 0;
            Console.WriteLine("Printing Fibonoccie Series");
            for (int i = 3; i <= n; i++)
            {
                sum = numb1 + numb2;
                Console.Write(" {0}", sum);
                numb1 = numb2;
                numb2 = sum;
            }
            if (n == 1)
            {
                Console.Write("{0} ", numb1);
            }
            else if (n == 2)
            {
                Console.Write("{0} {1}", numb1, numb2);
            }
            else
            {
                //Console.Write(numb1+" "+numb2); (this is the alternate method for line no 15)
                Console.Write("{0} {1}", numb1, numb2);
                
            }
        }
    }
}
