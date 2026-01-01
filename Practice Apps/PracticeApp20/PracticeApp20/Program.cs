namespace PracticeApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            catch 
            {
                Console.WriteLine("Error found.");
            }
            finally
            {
                Console.WriteLine("Finally executed."); // Code to execute regardless of exception
            }
        }
    }
}
