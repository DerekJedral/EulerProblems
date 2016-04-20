using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim = 20;


            int gridsize = dim+1;
            long[,] grid = new long[gridsize, gridsize];
            grid[0, 0] = 1;
            for (int i = 0; i < grid.GetLength(0); i++)
                grid[i, 0] = 1;

            for (int i = 0; i < grid.GetLength(1); i++)
                grid[0, i] = 1;

            for (int i=1; i<grid.GetLength(0); i++)
            {
                for (int j = 1; j < grid.GetLength(1); j++)
                    grid[i, j] = grid[i - 1,j] + grid[i,j - 1];
            }
            Console.WriteLine("max paths is " + grid[dim, dim]);
            Console.ReadLine();
        }
    }
}
