using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_25
{
    class Program
    {
        static string addStrings(string s1, string s2)
        {
            string s3 = "";
            int carry = 0;
            while (s1.Length>0 && s2.Length>0)
            {
                
                int sum = Convert.ToInt32(s1[s1.Length - 1] - '0') + Convert.ToInt32(s2[s2.Length - 1] - '0');
                sum = sum + carry;
                int newdigit = sum % 10;
                carry = Convert.ToInt32(Math.Floor(sum / 10.0));

                string newChar = Convert.ToString(newdigit);
                s3 = newChar + s3;
                s1 = s1.Substring(0, s1.Length - 1);
                s2 = s2.Substring(0, s2.Length - 1);

            }
            while (s1.Length != 0 || s2.Length !=0)
            {
                if (s1.Length != 0)
                {
                    int sum = Convert.ToInt32(s1[s1.Length - 1] - '0') + carry;
                    int newdigit = sum % 10;
                    carry = Convert.ToInt32(Math.Floor(sum / 10.0));
                    string newChar = Convert.ToString(newdigit);
                    s3 = newChar + s3;
                    s1 = s1.Substring(0, s1.Length - 1);
                }
                if (s2.Length !=0)
                {
                    int sum = Convert.ToInt32(s2[s2.Length - 1] - '0') + carry;
                    int newdigit = sum % 10;
                    carry = Convert.ToInt32(Math.Floor(sum / 10.0));
                    string newChar = Convert.ToString(newdigit);
                    s3 = newChar + s3;
                    s2 = s2.Substring(0, s2.Length - 1);
                }
            }
            while (carry!=0)
            {
                int lastdigit = carry % 10;
                carry = Convert.ToInt32(Math.Floor(carry / 10.0));
                string newChar = Convert.ToString(lastdigit);
                s3 = newChar + s3;
            }
            return s3;
        }

        static void Main(string[] args)
        {
            int max = 1000;

            int index = 1;
            string f1 = "1";
            string f2 = "1";

            while (f1.Length<max)
            {
                string f3 = addStrings(f1, f2);
                f1 = f2;
                f2 = f3;
                index++;
            }

            Console.WriteLine("index is " + index);
            Console.ReadLine();
        }
    }
}
