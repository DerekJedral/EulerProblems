using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDigits = 10;
            string[] numbers = System.IO.File.ReadAllLines(@"number.txt");
            int[] digits = new int[numDigits];
            for (int i = 0; i < digits.Length; i++)
                digits[i] = 0;

            int carry = 0;
            while(numbers[0].Length>0)
            {
                int sum = 0;
               

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum = sum + Convert.ToInt32(numbers[i][numbers[i].Length - 1] - '0');
                    numbers[i] = numbers[i].Substring(0, numbers[i].Length - 1);
                }
                sum = sum + carry;
                int newdigit = sum % 10;
                for (int i = digits.Length-1; i > 0; i--)
                    digits[i] = digits[i - 1];
                
                digits[0] = newdigit;
                carry = Convert.ToInt32(Math.Floor(sum / 10.0));
         
            }
			
			while (carry!=0)
            {
                int lastdigit = carry % 10;
                carry = carry - lastdigit;
                carry = carry / 10;
                for (int i = digits.Length - 1; i > 0; i--)
                    digits[i] = digits[i - 1];

                digits[0] = lastdigit;
            }
			
            Console.WriteLine("digits are: ");
            for (int i = 0; i < digits.Length; i++)
                Console.Write(digits[i]);

            Console.ReadLine();
        }
    }
}
