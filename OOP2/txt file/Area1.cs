using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            


            Console.WriteLine("Write the lenght of the rectangle : ");
            string a = Console.ReadLine();
            
            Console.WriteLine("Write the width of the rectangle : ");
            string b = Console.ReadLine();
            Console.WriteLine("Write the radius of the circle : ");
            string c = Console.ReadLine();
            Console.WriteLine("Write the lenght of the hight of the  triangle : ");
            string e = Console.ReadLine();
            
            Console.WriteLine("Write the bredth of the triangle : ");
            string f = Console.ReadLine();
            
            float d = 3.1416F;



            Console.WriteLine("area of the rectangle : " + (Convert.ToDouble(a)) * (Convert.ToDouble(b)));
            Console.WriteLine("area of the circle : " + (2 * (Convert.ToDouble(c)) * d));
            Console.WriteLine("area of the triangle : " + (0.5 * (Convert.ToDouble(e)) * (Convert.ToDouble(f))));

            
            
            
        }
    }
}
