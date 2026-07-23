using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask2
{
    internal class Program
    {
        static void Main()
        {
            int[,] twoDArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            Console.WriteLine("2D Array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(twoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
