using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask1
{
    internal class Program
    {
        static void Main()
        {
            int[] linearArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Linear Array:");
            foreach (int num in linearArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
