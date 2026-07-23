using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask_4
{
    internal class Program
    {

        public static void Main(String[]args)
        {
            int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
                             };

            int[,] matrix2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
                             };

            int[,] matrix3 = {
            { 1, 5, 8 },
            { 5, 1, 4 },
            { 9, 2, 3 }
                             };

            int[,] result = MultiplyMatrices(matrix1, matrix2);
            result = MultiplyMatrices(result, matrix3);

            PrintMatrix(result);
        }

        static int[,] MultiplyMatrices(int[,] a, int[,] b)
        {
            int rowsA = a.GetLength(0);
            int colsA = a.GetLength(1);
            int rowsB = b.GetLength(0);
            int colsB = b.GetLength(1);

            

            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            Console.WriteLine("THE RESULT IS : ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }   }
