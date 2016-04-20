using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cap = 100;
            int square_of_sum = Convert.ToInt32(Math.Pow(((cap * (cap + 1)) / 2),2));
            int sum_of_square = 0;
            for (int i = 1; i <= cap; i++)
                sum_of_square = sum_of_square + i * i;

            Console.WriteLine("difference is " + (square_of_sum-sum_of_square));
            Console.ReadLine();

        }
    }
}
