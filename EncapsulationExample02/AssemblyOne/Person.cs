using System;

namespace AssemblyOne
{
    public class Person
    {
        // Private: Only accessible within this class
        private string _ssn = "123-45-6789";

        // Public: Accessible from anywhere
        public string Name { get; set; }

        // Internal: Accessible within the same assembly
        internal int Age { get; set; }

        // Protected: Accessible in derived classes
        protected string Address { get; set; }

        // Protected Internal: Accessible within same assembly OR derived classes in different assemblies
        protected internal string PhoneNumber { get; set; }

        // Private Protected: Accessible within the same class and derived classes in the same assembly
        private protected string Email { get; set; } 

        public Person()
        {
            Name = "John Doe";
            Age = 30;
            Address = "123 Main St";
            PhoneNumber = "555-1234";
            Email = "john@example.com";
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
