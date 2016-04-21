using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_022
{
    class Program
    {
        static int getScore(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
                sum = sum + Convert.ToInt32(s[i] - 'A'+1);
            
            return sum;
        }
        static void Main(string[] args)
        {
            long sum = 0;
            String[] names = System.IO.File.ReadAllText(@"names.txt").Split(',');
            for (int i = 0; i < names.Length; i++)
                names[i] = names[i].Substring(1, names[i].Length - 2);

            for (int i = 1; i < names.Length; i++ )
            {
                if (String.Compare(names[i], names[i - 1], false)<0)
                {
                    string tmp = names[i];
                    names[i] = names[i - 1];
                    names[i - 1] = tmp;
                    i--;
                    i--;
                    if (i < 0) i = 0;
                }
            }

            for (int i = 0; i < names.Length; i++)
                sum = sum + getScore(names[i]) * (i + 1);
 
            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
