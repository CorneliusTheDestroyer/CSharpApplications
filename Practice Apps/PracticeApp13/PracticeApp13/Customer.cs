namespace PracticeApp13
{
    internal class Customer
    {
        private string name;
        //public string Name { get { return name; } }
        public string Name => name;
        public int Age { get; set; }

        public Customer(int age) => Age = age;

        public int calc(int age) => Age + age;

        public void call() => Console.WriteLine("Testing Expression Bodied Methods.");
    }
}
