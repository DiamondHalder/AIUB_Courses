using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK3
{
    internal class Program
    {
        struct Student
        {
            public string Name;
            public string Birthday;
            public string Address;
            public string City;
            public string ZipCode;
            public string Country;
        }

        static void Main(string[] args)
        {
            // Creating a student struct and taking input
            Student student;

            Console.Write("Enter name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter birthday (MM/DD/YYYY): ");
            student.Birthday = Console.ReadLine();
            Console.Write("Enter address: ");
            student.Address = Console.ReadLine();
            Console.Write("Enter city: ");
            student.City = Console.ReadLine();
            Console.Write("Enter zip code: ");
            student.ZipCode = Console.ReadLine();
            Console.Write("Enter country: ");
            student.Country = Console.ReadLine();

            // Printing values
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Birthday: " + student.Birthday);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("City: " + student.City);
            Console.WriteLine("Zip Code: " + student.ZipCode);
            Console.WriteLine("Country: " + student.Country);
        }
    }
}

