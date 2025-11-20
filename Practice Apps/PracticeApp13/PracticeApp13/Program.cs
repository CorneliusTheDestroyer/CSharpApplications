namespace PracticeApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Customer customer = new Customer(26);

            int newAge = customer.calc(12);

            Console.WriteLine(newAge);

            customer.call();
        }
    }
}
