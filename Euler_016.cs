using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_16
{
    class Program
    {
        static string MultiplyString(string s, int x)
        {
            int carryover = 0;
            string s2 = "";
            while (s.Length > 0)
            {
                int lastdigit = Convert.ToInt32(s[s.Length - 1] - '0');
                int multLast = lastdigit * x + carryover;
                int newLast = multLast % 10;
                carryover = (multLast - newLast) / 10;
                s2 = Convert.ToString(newLast) + s2;
                s = s.Substring(0, s.Length - 1);
            }

            if (carryover != 0)
                s2 = Convert.ToString(carryover) + s2;

            return s2;
        }

        static void Main(string[] args)
        {
            string x = "1";
            int pow = 2;
            int exponent = 1000;
            for (int i=1; i<=exponent; i++)
                x = MultiplyString(x, pow);
            
            int sum =0;
            for (int i = 0; i < x.Length; i++)
                sum = sum + Convert.ToInt32(x[i] - '0');

            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
