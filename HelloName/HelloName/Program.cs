using System;

namespace HelloName
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            Console.ReadKey();
        }
    }
}
