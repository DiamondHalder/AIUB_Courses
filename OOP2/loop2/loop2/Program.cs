using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the multi dimentional array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());

            int[][] num = new int[size][col];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                //num[i] = Convert.ToInt32(Console.ReadLine());
                for (int j = 0;j<col;j++)
                {
                    num[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nYou entered the following elements:");

            for (int i = 0; i < size; i++)
            {
                //num[i] = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine(num[i][j]);
                }
            }

            

            Console.ReadKey();

        }
    }
}
