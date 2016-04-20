using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long target = 600851475143;
            long limit = target;
            long max = 2;
            for (int i = 2; i < limit; i++ )
            {
                if (i==limit-1)
                {
                    max = limit;
                    break;
                }
                if (limit%i==0)
                {
                    if (max < i) max = i;
                    limit = limit / i;
                    i--;
                }
            }
                Console.WriteLine("largest prime factor is "+max);
                Console.ReadLine();
        }
    }
}
