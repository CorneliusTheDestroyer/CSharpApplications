using System;
using System.Collections;
using System.Linq;

namespace EnumExamplesChatGPT
{
    enum DaysOfWeek
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
        static void Main()
        {
            DaysOfWeek today = DaysOfWeek.Wednesday;
            Console.WriteLine($"Today is {today}");

            // Enum to int conversion
            int dayNumber = (int)today;
            Console.WriteLine($"Numeric value of {today} is {dayNumber}");

            // Int to Enum conversion
            DaysOfWeek dayFromNumber = (DaysOfWeek)4;
            Console.WriteLine($"Day at index 4 is {dayFromNumber}");

            // Checking if a value is defined in the Enum
            if (Enum.IsDefined(typeof(DaysOfWeek), 6))
            {
                Console.WriteLine("6 is a valid day index.");
            }
        }
    }
}

