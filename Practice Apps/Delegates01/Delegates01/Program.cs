namespace Delegates01
{
    public delegate void Process(string message);
    internal class Program
    {
        static void Main()
        {
            Process processPolicy = Policy;

            processPolicy("Process Policy");

            processPolicy = Risk;

            processPolicy("Process Risk");
            
        }

        static void Policy(string message) 
        {
            Console.WriteLine(message);
        }

        static void Risk(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
