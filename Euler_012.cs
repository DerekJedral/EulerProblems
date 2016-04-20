using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_12
{
    class Program
    {
        static int getNumFactors(int x)
        {
            int counter = 0;
            int[] primeArray = new int[x + 1];

            for (int j = 0; j < primeArray.Length; j++)
                primeArray[j] = 0;

            int limit = x;
            for (int j = 2; j <= limit; j++)
            {
                if (j == limit)
                {
                    primeArray[j]++;
                    counter++;
                    break;
                }
                if (limit % j == 0)
                {
                    counter++;
                    primeArray[j]++;
                    limit = limit / j;
                    j--;
                }
            }
            if (counter < 9) return -1;
            int totalFactors = 1;
            for (int i = 0; i < primeArray.Length; i++)
                totalFactors = totalFactors * (primeArray[i] + 1);
            
            return totalFactors;
        }
        static void Main(string[] args)
        {
            int triangle = 0;
            int counter = 1;
            int numDivisors = 500;

            while(true)
            {
                triangle = triangle + counter;
                counter++;
                int totalDiv = getNumFactors(triangle);
                Console.WriteLine("counter is " + counter+", totaldivisors is "+totalDiv);
                if (totalDiv > numDivisors) break;
            }

            Console.WriteLine("smallest triangle is " + triangle);
            Console.ReadLine();
        }
    }
}
