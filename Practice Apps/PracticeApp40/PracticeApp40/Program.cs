namespace PracticeApp40
{
    public delegate void AlertMessage(string message);

    internal class Program
    {
        private static void Main()
        {
            AlertMessage alert = ErrorMessage;

            alert("This is an error");

            alert = InfoMessage;

            alert("This is info");
        }

        private static void ErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void InfoMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
