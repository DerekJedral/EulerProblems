using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_7
{
    class Program
    {
        static bool isPrime(int x)
        {
            for (int i=2; i<=Convert.ToInt32(Math.Sqrt(x)); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int max = 10001;
            int counter = 0;
            int i = 2;
            while (counter!=max)
            {
                if (isPrime(i)) counter++;
                i++;
            }
            Console.WriteLine(max + " prime number is " + (i - 1));
            Console.ReadLine();
        }
    }
}
