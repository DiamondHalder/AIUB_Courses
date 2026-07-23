using System;

class Program
{
    static void ModifyRefValue(ref int value)
    {
        value = 10;
    }

    static void GetOutValue(out int value)
    {
        value = 10;
    }

    static int Values(params int[] values)
    {
        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }
        return sum;
    }

    static void PrintJaggedArray(int[][] jaggedArray)
    {
        foreach (int[] array in jaggedArray)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int refValue = 5;
        Console.WriteLine("Initial ref value: " + refValue);

        ModifyRefValue(ref refValue);
        Console.WriteLine("Modified ref value: " + refValue);

        int outValue = 5;
        GetOutValue(out outValue);
        Console.WriteLine("Out value: " + outValue);

        int value= Values(1, 2, 3, 4, 5);
        Console.WriteLine("Params values: " + value);

        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        PrintJaggedArray(jaggedArray);
        Console.ReadKey();
    }
}