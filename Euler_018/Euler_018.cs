using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_18
{


    class Program
    {
        static int findPath(int[] a, int r)
        {
            if (a.Length == 1)
                return a[0];

            int[] aNew = new int[a.Length - r];

            for (int i = 0; i < a.Length - r - (r - 1); i++)
                aNew[i] = a[i];

            for (int i = a.Length - r - (r - 1); i < a.Length - r; i++)
                aNew[i] = a[i] + Math.Max(a[i + r], a[i + r - 1]);

            return findPath(aNew, r - 1);
        }
        static int findnum(int x)
        {

            int goal = 2 * x;
            int cur = 1;
            while (cur * (cur + 1) != goal)
                cur++;

            return cur;
        }
        static void Main(string[] args)
        {
            string triangle = System.IO.File.ReadAllText(@"triangle.txt");
            string[] splitTriangle = triangle.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            int[] numTriangles = new int[splitTriangle.Length];
            for (int i = 0; i < numTriangles.Length; i++)
                numTriangles[i] = Convert.ToInt32(splitTriangle[i]);

            int numrows = findnum(numTriangles.Length);

            int max = findPath(numTriangles, numrows);
            Console.WriteLine("max is " + max);
            Console.ReadLine();
        }
    }
}