namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Customer customer = new Customer();
            Customer customer1 = new Customer("John");
            Customer customer2 = new Customer("Mike");
            Customer customer3 = new Customer("Dan", 23);

            customer._Id = 232323;

            Console.WriteLine($"Customer has an ID of {customer._Id}");

            customer.Register(); 
            customer1.Register();
            customer2.Register();
            customer3.Register();
            customer3.Register("Micheal", 43);
        }
    }
}
