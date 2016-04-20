using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int var1 = 3;
            int var2 = 5;
            int max = 1000;
            for (int i=0; i<max; i++)
            {
                if (i % var1 == 0 && i % var2 == 0) sum = sum + i;
                else if (i % var1 == 0) sum = sum + i;
                else if (i % var2 == 0) sum = sum + i;
            }
            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
