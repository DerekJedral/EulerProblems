using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int upTo = 20;


            int[] primeArray = new int[upTo + 1];
            for (int i = 0; i < primeArray.Length; i++)
                primeArray[i] = 0;
            for (int i = 2; i <= upTo; i++)
            {
                int[] primeArrayTMP = new int[upTo + 1];
                
                for (int j = 0; j < primeArrayTMP.Length; j++)
                    primeArrayTMP[j] = 0;

                int limit = i;
                for (int j = 2; j <= limit; j++)
                {
                    if (j == limit)
                    {
                        primeArrayTMP[j]++;
                        break;
                    }
                    if (limit % j == 0)
                    {
                        primeArrayTMP[j]++;
                        limit = limit / j;
                        j--;
                    }
                }

                for (int j=0; j<primeArrayTMP.Length; j++)
                {
                    if (primeArrayTMP[j] > primeArray[j])
                        primeArray[j] = primeArrayTMP[j];
                }
            }
            int smallest = 1;
            for (int i = 1; i < primeArray.Length; i++)
                smallest = smallest * Convert.ToInt32(Math.Pow(i, primeArray[i]));

            Console.WriteLine("smallest positive number is " + smallest);
            Console.ReadLine();
        }
    }
}
