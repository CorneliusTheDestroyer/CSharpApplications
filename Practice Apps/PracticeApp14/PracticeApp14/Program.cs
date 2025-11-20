namespace PracticeApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 5);
            Vector v2 = new Vector(7, 2);
            Vector result = v1 + v2;

            result.Display();
        }
    }
}
