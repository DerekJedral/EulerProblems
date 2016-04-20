using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_19
{
    class Program
    {
        static int DaysInYear(int x)
        {
            int DaysInYear = 365;
            if (x % 4 == 0)
            {
                if (x % 100 == 0)
                {
                    if (x % 400 == 0)
                        DaysInYear++;
                }
                else
                    DaysInYear++;
            }
            return DaysInYear;
        }
        static int findSundays(int year, int startDay)
        {
            int totalSundays = 0;
            int [] months = new int [13];
            months[1]=31;
            months[2] =28;
            months[3] = 31;
            months[4] = 30;
            months[5] = 31;
            months[6] = 30;
            months[7] = 31;
            months[8] = 31;
            months[9] = 30;
            months[10] = 31;
            months[11] = 30;
            months[12] = 31;

            if (DaysInYear(year) == 366)
                months[2] = 29;
            for (int i=1; i<=12; i++)
            {
                if (startDay % 7 == 0)
                    totalSundays++;
 
                startDay = startDay + months[i];
            }
            return totalSundays;
        }
        static void Main(string[] args)
        {
            int yearCurrent = 1901;
            int yearEnd = 2000;


            int dayCurrent = 2;
            int totalSundays = 0;
            for (int i=yearCurrent; i<=yearEnd; i++)
            {
                totalSundays = totalSundays + findSundays(i, dayCurrent);
                dayCurrent = (dayCurrent+DaysInYear(i))%7;           
            }

            Console.WriteLine("total sundays is " + totalSundays);
            Console.ReadLine();
        }
    }
}
