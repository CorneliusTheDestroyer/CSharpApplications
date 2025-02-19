using System;
using AssemblyOne; // Reference to AssemblyOne

namespace AssemblyTwo
{
    public class Employee : Person // Inheriting from Person
    {
        public void ShowDetails()
        {
            // ✅ Public - accessible anywhere
            Console.WriteLine($"Name: {Name}");

            // ❌ Private - not accessible
            // Console.WriteLine($"SSN: {_ssn}"); 

            // ❌ Internal - not accessible from another assembly
            // Console.WriteLine($"Age: {Age}"); 

            // ✅ Protected Internal - accessible in derived classes
            Console.WriteLine($"Phone Number: {PhoneNumber}");

            // ❌ Private Protected - not accessible in a different assembly
            // Console.WriteLine($"Email: {Email}"); 
        }
    }
}
