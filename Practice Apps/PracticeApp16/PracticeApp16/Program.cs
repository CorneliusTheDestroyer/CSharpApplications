namespace PracticeApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 25);

            //person.Display();
            Person.Display();

            var myNamesList = new List<string> { "Test01", "Test02", "Test03" };

            myNamesList.Add(person.Name);
            myNamesList.Remove("Test02");
            myNamesList.Sort();

            foreach (var name in myNamesList)
            {
                Console.WriteLine($"Names: {name}");
            }
        }
    }
}
