using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_10
{
    class Program
    {
        static bool isPrime(int x)
        {
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(x)); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int max = 2000000;
            int sum = 0;
            for (int i = 2; i < max; i++ )
                if (isPrime(i)) sum = sum+i;
             
            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
