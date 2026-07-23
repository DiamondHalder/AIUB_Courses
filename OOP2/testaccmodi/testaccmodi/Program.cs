using System;

class OutExample
{
    static void GetValues(out int number, out string message)
    {
        number = 42; // Assign a value to the out parameter
        message = "Hello, World!";
    }

    static void Main()
    {
        int myNumber=10;
        string myMessage ="ajdsha";
        Console.WriteLine("Number: " + myNumber); 
        Console.WriteLine("Message: " + myMessage);

        GetValues(out myNumber, out myMessage);

        Console.WriteLine("Number: " + myNumber); // Output: 42
        Console.WriteLine("Message: " + myMessage); // Output: Hello, World!

        Console.ReadKey();
    }
}