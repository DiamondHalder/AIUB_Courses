using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompting user for input
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter birthday (MM/DD/YYYY): ");
            string birthday = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter zip code: ");
            string zipCode = Console.ReadLine();
            Console.Write("Enter country: ");
            string country = Console.ReadLine();

            // Printing values
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Birthday: " + birthday);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Zip Code: " + zipCode);
            Console.WriteLine("Country: " + country);
        }
    }
}

