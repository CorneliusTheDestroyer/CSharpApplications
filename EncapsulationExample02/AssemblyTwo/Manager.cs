using System;
using AssemblyOne; // Reference to AssemblyOne

namespace AssemblyTwo
{
    public class Manager
    {
        public void AccessPersonDetails()
        {
            Person person = new Person();

            // ✅ Public - accessible
            Console.WriteLine($"Name: {person.Name}");

            // ❌ Internal - not accessible from another assembly
            // Console.WriteLine($"Age: {person.Age}"); 

            // ❌ Protected Internal - only accessible in derived classes
            // Console.WriteLine($"Phone Number: {person.PhoneNumber}"); 
        }
    }
}
