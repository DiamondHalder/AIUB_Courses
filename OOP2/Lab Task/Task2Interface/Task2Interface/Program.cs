using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task2Interface
{
    internal class Program
    {

        interface Printer
        {
            void Print(string content);
            int CheckInkLevel();
            int Price();
        }

        interface Scanner
        {
            void Scan(string document);
            int CheckScanResolution();
            int Price();
        }

        class MultiFunctionDevice : Printer, Scanner
        {
            private int inkLevel = 100;
            private int scanResolution = 300;

            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
                inkLevel -= 10;  
            }

            public int CheckInkLevel()
            {
                return inkLevel;
            }

            public int CheckScanResolution()
            {
                return scanResolution;
            }

            int Printer.Price()
            {
                return 150;
            }

            int Scanner.Price()
            {
                return 100;
            }

            public void Scan(string document)
            {
                Console.WriteLine($"Scanning: {document}");
            }
        }
        static void Main(string[] args)
        {
            MultiFunctionDevice obj = new MultiFunctionDevice();

            // Printer functionality
            Printer printer = obj;
            printer.Print("Document 1");
            Console.WriteLine("Ink Level: " + printer.CheckInkLevel());
            Console.WriteLine("Printer Price: " + printer.Price());

            // Scanner functionality
            Scanner scanner = obj;
            scanner.Scan("Document 2");
            Console.WriteLine("Scan Resolution: " + scanner.CheckScanResolution());
            Console.WriteLine("Scanner Price: " + scanner.Price());
        }
    }
}
