using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_17
{
    class Program
    {
        static int CountLetters(int x)
        {
            if (x == 1000) return 11;
            int sum = 0;
            int[] numArray = new int[100];
            numArray[0] = 0;
            numArray[1] = 3;
            numArray[2] = 3;
            numArray[3] = 5;
            numArray[4] = 4;
            numArray[5] = 4;
            numArray[6] = 3;
            numArray[7] = 5;
            numArray[8] = 5;
            numArray[9] = 4;
            numArray[10] = 3;
            numArray[11] = 6;
            numArray[12] = 6;
            numArray[13] = 8;
            numArray[14] = 8;
            numArray[15] = 7;
            numArray[16] = 7;
            numArray[17] = 9;
            numArray[18] = 8;
            numArray[19] = 8;
            numArray[20] = 6;
            numArray[30] = 6;
            numArray[40] = 5;
            numArray[50] = 5;
            numArray[60] = 5;
            numArray[70] = 7;
            numArray[80] = 6;
            numArray[90] = 6;

            int and = 3;
            int hundred = 7;

            sum = sum + numArray[Convert.ToInt32(Math.Floor(x / 100.0))];
            if (sum > 0)
            {
                sum = sum + hundred;
                if (x % 100 != 0)
                    sum = sum + and;

            }
            

            x = x % 100;
            if (x < 20)
                sum = sum + numArray[x];

            else
            {
                sum = sum + numArray[Convert.ToInt32(Math.Floor(x / 10.0)) * 10];
                sum = sum + numArray[x % 10];
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int start = 1;
            int end = 1000;
            for (int i = start; i <= end; i++)
                sum = sum + CountLetters(i);

            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
