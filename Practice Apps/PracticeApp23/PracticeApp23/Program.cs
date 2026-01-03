using System.Security.Cryptography.X509Certificates;

namespace PracticeApp23
{
    public class Person
    {
        public string? Name { get; set; }

        public Person(string name)
        {
            Name = name;

            Console.WriteLine($"Person constructor: {name}");
        }
    }

    public class Employee : Person
    {
        public int ID { get; set; }

        public Employee(string name, int id) : base(name)
        {
            ID = id;

            Console.WriteLine($"Employee constructor: {name}, ID: {id}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee("John Doe", 123);
        }
    }
}
