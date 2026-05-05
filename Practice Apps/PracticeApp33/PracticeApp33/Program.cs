namespace PracticeApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, "Hello World" + "\n");
        }
    }
}
