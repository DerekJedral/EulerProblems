using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000000;
            int[] visited = new int[max];
            for (int i = 0; i < visited.Length; i++)
                visited[i] = 0;

            visited[0] = -1;
            for (int i = 1; i < visited.Length; i++)
            {
                int counter = 1;
                if (visited[i] == 0)
                {
                    long x = i;
                    
                    while (x != 1)
                    {
                        if (x % 2 == 0)
                            x = x / 2;

                        else
                            x = 3 * x + 1;

                        if (x < max)
                            visited[x] = -1;
                        
                        counter++;
                    }
                    visited[i] = counter;
                }
            }
            int maxLength = -1;
            int maxIndex = 0;
            for (int i = 0; i < visited.Length; i++)
            {
                if (maxLength< visited[i])
                {
                    maxIndex = i;
                    maxLength = visited[i];
                }
                maxLength = Math.Max(maxLength, visited[i]);
            }
            Console.WriteLine("max chain is " + maxLength + " with starting number "+maxIndex);
            Console.ReadLine();
        }
    }
}
