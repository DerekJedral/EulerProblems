using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_21
{
    class Program
    {
        static int addLoop(int [,] primeCondensed, int i, int prevMult)
        {
            int sum = 0;
            if (i == primeCondensed.GetLength(0) - 1)
            {
                
                for (int j = 0; j <= primeCondensed[i,1]; j++)
                    sum = sum + prevMult * Convert.ToInt32(Math.Pow(primeCondensed[i,0], j));
                return sum;
            }
            else
            {
                for (int j = 0; j <= primeCondensed[i,1]; j++)
                {
                    int newMult = prevMult * Convert.ToInt32(Math.Pow(primeCondensed[i, 0], j));
                    sum = sum + addLoop(primeCondensed, i + 1, newMult);
                }
                return sum;
            }
                

        }

        static int addDivisors(int i)
        {
            int[] primeArray = new int[i + 1];

            for (int j = 0; j < primeArray.Length; j++)
                primeArray[j] = 0;

            int limit = i;
            int counter = 0;
            for (int j = 2; j <= limit; j++)
            {
                if (j == limit)
                {
                    if (primeArray[j]==0)
                        counter++;
                    primeArray[j]++;
                    break;
                }
                if (limit % j == 0)
                {
                    if (primeArray[j] == 0)
                        counter++;
                    primeArray[j]++;
                    limit = limit / j;
                    j--;
                }
            }
            int[,] primeCondensed = new int[counter, 2];
            int index = 0;
            for (int j=0; j<primeArray.Length; j++)
            {
                if (primeArray[j]>0)
                {
                    primeCondensed[index, 0] = j;
                    primeCondensed[index, 1] = primeArray[j];
                    index++;
                }
            }
            int sum;
            if (counter != 0)
            {
                sum = addLoop(primeCondensed, 0, 1);
                return sum-i;
            }
            else
                return 1;
        }
        static void recurseLoop(int start, int next, int[]amicable)
        {
            if (start!=next)
            {
                if (start<amicable.Length)
                {
                    if (amicable[start]==0)
                    {
                        int x = addDivisors(next);
                        if (x == start)
                        {
                            amicable[start] = 1;
                            if (x<amicable.Length)
                                amicable[x] = 1;
                        }
                        else
                        {
                            amicable[start] = -1;
                            recurseLoop(next, x, amicable);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int max = 10000;


            int[] amicable = new int[max];
            for (int i = 0; i > amicable.Length; i++)
                amicable[i] = 0;

            for (int i = 2; i < max; i++)
            {
                int next = addDivisors(i);
                recurseLoop(i, next, amicable);
            }

            int sum=0;
            for (int i=1; i<amicable.Length; i++)
            {
                if (amicable[i] > 0)
                    sum = sum + i;
            }

            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
