using System;

namespace OutExample
{
    class Program
    {
        // Method that uses out to return multiple values
        static void GetValues(out int number, out string text)
        {
            number = 42;             // Assigning a value to the out parameter
            text = "Hello, World!";  // Assigning a value to the out parameter
        }

        static void Main(string[] args)
        {
            int myNumber=55;
            string myText="Nothing";

            Console.WriteLine($"Before \n Number: {myNumber}");  
            Console.WriteLine($"Text: {myText}");

            GetValues(out myNumber, out myText);  // Passing uninitialized variables

            Console.WriteLine($"After \n Number: {myNumber}");  // Output: Number: 42
            Console.WriteLine($"Text: {myText}");      // Output: Text: Hello, World!
        }
    }
}
