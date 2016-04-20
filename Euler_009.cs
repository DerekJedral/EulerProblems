using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<= 333; i++)
            {
                bool breakflag = false;
                for (int j=i; j<(1000-i)/2; j++)
                {
                    int k = 1000 - j - i;
                    if (i*i+j*j == k*k)
                    {
                        Console.WriteLine("product is " + (i * j * k));
                        Console.ReadLine();
                        breakflag = true;
                        break;
                    }
                }
                if (breakflag == true) break;
            }
        }
    }
}
