using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_23
{
    class Program
    {
        static int addLoop(int[,] primeCondensed, int i, int prevMult)
        {
            int sum = 0;
            if (i == primeCondensed.GetLength(0) - 1)
            {

                for (int j = 0; j <= primeCondensed[i, 1]; j++)
                    sum = sum + prevMult * Convert.ToInt32(Math.Pow(primeCondensed[i, 0], j));
                return sum;
            }
            else
            {
                for (int j = 0; j <= primeCondensed[i, 1]; j++)
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
                    if (primeArray[j] == 0)
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
            for (int j = 0; j < primeArray.Length; j++)
            {
                if (primeArray[j] > 0)
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
                return sum - i;
            }
            else
                return 1;
        }

        static void Main(string[] args)
        {
            int [] abundant = new int [28124];

            for (int i = 0; i < abundant.Length; i++)
                abundant[i] = 0;

            int counter=0;

            for ( int i=2; i<abundant.Length; i++)
            {
                int sum = addDivisors(i);
                if (sum > i)
                {
                    abundant[i]++;
                    counter++;
                }
            }

            int[] abundantCondensed = new int[counter];
            int index=0;

            for (int i=0; i<abundant.Length; i++)
            {
                if (abundant[i]>0)
                {
                    abundantCondensed[index] = i;
                    index++;
                }
            }

            bool[] possibleSums = new bool[28124];

            for (int i = 0; i < possibleSums.Length; i++)
                possibleSums[i] = false;

            for (int i = 0; i < abundantCondensed.Length; i++)
            {
                for (int j = i; j < abundantCondensed.Length; j++)
                {
                    int sum = abundantCondensed[i] + abundantCondensed[j];
                    if (sum < possibleSums.Length)
                        possibleSums[sum] = true;
                }
            }

            long cannotSum = 0;
            for (int i = 0; i < possibleSums.Length; i++)
            {
                if (possibleSums[i] == false)
                    cannotSum = cannotSum + i;

            }
            Console.WriteLine("sum is " + cannotSum);
            Console.ReadLine();
        }
    }
}
