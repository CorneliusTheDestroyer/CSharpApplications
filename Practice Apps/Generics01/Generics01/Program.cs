namespace Generics01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Content = 1;

            Console.WriteLine(box.Log());

            Box<string> boxStr = new Box<string>();
            boxStr.Content = "Hello";

            Console.WriteLine(boxStr.Log());
        }
    }
}
