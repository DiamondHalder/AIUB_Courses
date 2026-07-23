using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string a=Console.ReadLine();
            Console.WriteLine("enter your age");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadKey();

        }
    }
}
