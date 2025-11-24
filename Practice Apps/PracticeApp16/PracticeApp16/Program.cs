namespace PracticeApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 25);

            //person.Display();
            Person.Display();

            //var myNamesList = new List<string> { "Test01", "Test02", "Test03" };
            List<string> myNamesList = new List<string> { "Test01", "Test02", "Test03" };

            myNamesList.Add(person.Name);
            myNamesList.Remove("Test02");
            myNamesList.Sort();

            foreach (var name in myNamesList)
            {
                Console.WriteLine($"Names: {name}");
            }

            var people = new List<Person>
            {
                new Person("Mike", 28),
                new Person("Bryan", 23)
            };

            foreach (var per in people)
            {
                Console.WriteLine($"Person: {per.Name}, Age: {per.Age}");
            }
        }
    }
}
