using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4
{
    class Program
    {
        static int isPalindrome(int x)
        {
            string xStr = Convert.ToString(x);
            for (int i = 0; i < xStr.Length / 2; i++ )
            {
                if (xStr[i] != xStr[xStr.Length - i - 1])
                    return -1;
            }
                return x;
        }
        static void Main(string[] args)
        {
            int numDigits = 3;
            int max = Convert.ToInt32(Math.Pow(10, numDigits)-1);
            int min = Convert.ToInt32(Math.Pow(10, numDigits-1));
            int num1=0;
            int num2=0;
            int palindrome =0;
            for (int i=max; i>=min; i--)
            {
                if (i<=num2)break;
                for (int j=i; j>=min; j--)
                {
                    int result = isPalindrome(i * j);

                    if (result > palindrome)
                    {
                        num1 = i;
                        num2= j;
                        palindrome = result;
                    }
                }
            }
            Console.WriteLine("max palindrome is " + palindrome);
            Console.ReadLine();
        }
    }
}
