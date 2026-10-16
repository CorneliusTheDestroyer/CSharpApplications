namespace Delegates02
{
    public delegate void ProcessMessage(string message);

    internal class Program
    {
        private static void Main()
        {
            ProcessMessage processMessage = MessageToFile;

            //processMessage("Processing this message to a file.");

            processMessage += MessageToConsole;

            //processMessage("Processing this message to the console");

            //processMessage("Processing messages...");

            processMessage -= MessageToFile;

            processMessage("Processing messages...");
        }

        public static void MessageToFile(string message)
        {
            Console.WriteLine(@"File: {0}", message);
        }

        public static void MessageToConsole(string message)
        {
            Console.WriteLine(@"Console: {0}", message);
        }
    }
}
