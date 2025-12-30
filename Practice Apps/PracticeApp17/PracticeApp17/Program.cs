namespace PracticeApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> myPersonList = new List<Person> {
                new Person{ Name = "Bill", Age = 28 },
                new Person{ Name = "Sam", Age = 18},
                new Person{ Name = "Madilyn", Age = 20}
            };

            Console.WriteLine("All person: ");

            foreach (Person person in myPersonList) {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            Console.WriteLine("Age > 20: (Simple example for now)");

            List<int> ageList = new List<int> { 18, 16, 23, 28, 32 }; 

            Predicate<int> overTwentyList = x => x > 20;

            List<int> myFindAllList = ageList.FindAll(overTwentyList);

            foreach (var item in myFindAllList)
            {
                Console.WriteLine(item);
            }

            bool hasLargeNumbers = ageList.Any(x => x > 20);

            if (hasLargeNumbers)
            {
                Console.WriteLine("This list has members over 20 years of age.");
            }
            else
            {
                Console.WriteLine("This list does NOT have any members over 20 years of age.");
            }
        }
    }
}
