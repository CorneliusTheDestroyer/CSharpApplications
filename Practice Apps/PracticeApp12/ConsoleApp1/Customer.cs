using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customer
    {
        //Member Variable
        public int _Id = 0;

        //Properties
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructors
        public Customer(string name) 
        {
            Name = name;
            Console.WriteLine($"Customer {Name} created");
        }

        public Customer()
        {
            Name = "Defaut Name";
            Console.WriteLine($"Customer {Name} created");
        }

        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Customer {Name} created with an age of {Age}");
        }

        public void Register()
        {
            Console.WriteLine($"Customer {Name} successfully registered");
        }

        public void Register(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Customer {Name} with an age of {Age} successfully registered");
        }

    }
}
 