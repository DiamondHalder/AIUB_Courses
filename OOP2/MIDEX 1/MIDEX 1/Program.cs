using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDEX_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[4][];
            jagged[0] = new int[] { 1,3,5,7,9,11,13,15};
            jagged[1] = new int[3];
            jagged[2]=new int[] { 2,4,6,8,10,12,14,16};
            jagged[3]=new int[3];
            for(int row = 0; row < 4; row += 2)
            {
                for(int column = 0; column < jagged[row].Length; column+=3)
                {
                    Console.Write(" "+jagged[row][column]);
                } Console.WriteLine();
            }
            for(int index = 0; index < jagged[1].Length;index+=2)
            {
                jagged[1][index] = jagged[0][index + 2]- jagged[0][index];

                
            }
            for(int index = 0; index < jagged[3].Length;index++)
            {
                jagged[3][index] = jagged[2][index ++]+ jagged[2][index+3];
            }
            for(int row = 1; row < 4; row += 2)
            {
                for (int column = 0; column < jagged[row].Length; column += 2)
                {
                    Console.Write(" " + jagged[row][column]);
                }
                Console.WriteLine();
            }


                
               // Console.WriteLine(jagged[1].Length);
           

                Console.ReadKey();

           
        }
    }
}
