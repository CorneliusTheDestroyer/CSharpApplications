using System;
using AssemblyOne;
using AssemblyTwo;

namespace EncapsulationExample02
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            // ✅ Allowed because it's a public method
            person.DisplayPersonInfo(); 

            Employee employee = new Employee();
            // ✅ Allowed
            employee.ShowDetails(); 

            Manager manager = new Manager();
            // ✅ Allowed
            manager.AccessPersonDetails(); 
        }
    }
}
