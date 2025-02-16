using System;

class Person
{
    // Private fields (cannot be accessed directly from outside the class)
    private string name;
    private int age;

    // Public properties to get and set private fields with validation
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Age must be positive.");
        }
    }

    // Public method to display information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        // Using properties to set values (encapsulation ensures validation)
        person.Name = "John Doe";
        person.Age = 30;

        person.DisplayInfo(); // Output: Name: John Doe, Age: 30

        // Attempting to set an invalid age
        person.Age = -5; // Output: Age must be positive.
    }
}
