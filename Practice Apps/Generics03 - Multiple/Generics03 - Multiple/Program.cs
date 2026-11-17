namespace Generics03___Multiple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Box<int, string> box = new Box<int, string>(01, "Message01");
            box.Display();
        }
    }
}
