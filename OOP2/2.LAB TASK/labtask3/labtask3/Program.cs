using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask3
{
    internal class Program
    {
        static void Main()
        {
            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            jaggedArray[3] = new int[] { 10 };
            jaggedArray[4] = new int[] { 11, 12 };

            Console.WriteLine("Jagged Array:");
            foreach (int[] innerArray in jaggedArray)
            {
                foreach (int num in innerArray)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
