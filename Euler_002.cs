using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 1;
            int fib2 = 2;
            int sum = 0;
            int max = 4000000;
            while (fib1<max)
            {
                if (fib1 % 2 == 0) sum = sum + fib1;
                int fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
            }
            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
