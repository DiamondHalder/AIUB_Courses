using System;

namespace SimpleEnumExample
{
    // Define an enum for days of the week
    enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Assign an enum value to a variable
            DayOfWeek today = DayOfWeek.Wednesday;

            // Check the day and print a message
            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                Console.WriteLine("It's the weekend! Time to relax.");
            }
            else
            {
                Console.WriteLine($"It's {today}. Keep working hard!");
            }
        }
    }
}




