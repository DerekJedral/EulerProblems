using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_24
{
    class Program
    {
        static int Factorial(int x)
        {
            int mult=1;
            for (int i = 1; i <= x; i++)
                mult = mult * i;

            return mult;
        }

        static string getPermutation(int goal, int digitsused, char [] digits, string s)
        {
            digitsused++;
            int current = 0;
            int numOfPermutations = Factorial(digits.Length - digitsused);
            
            if (digitsused > digits.Length) return s;

            for (int i=0; i<10-digitsused+1; i++)
            {
                if (current + numOfPermutations >= goal)
                {
                    s = s + Convert.ToString(digits[i]);

                    for (int k = i; k < digits.Length-1; k++)
                        digits[k] = digits[k + 1];

                    s = getPermutation(goal - current, digitsused, digits, s);
                    return s;
                }

                else
                    current = current + numOfPermutations;
            }
            return "";
        }

        static void Main(string[] args)
        {
            char[] digits = new char[10];
            for (int i = 0; i < digits.Length; i++)
                digits[i] = Convert.ToChar(i+'0');

            int goal = 1000000;
            int digitsUsed = 0;
            string result = getPermutation(goal, digitsUsed, digits, "");
            Console.WriteLine("Result is " + result);
            Console.ReadLine();
            
        }
    }
}
