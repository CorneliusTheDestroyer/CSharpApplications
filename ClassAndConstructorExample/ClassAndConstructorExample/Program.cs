using System;

namespace ClassAndConstructorExample
{
    class Car
    {
        // Attributes (Fields)
        public string Brand;
        public string Color;
        public int Speed;

        // Constructor (initializes the object)
        public Car(string brand, string color, int speed)
        {
            Brand = brand;
            Color = color;
            Speed = speed;
        }

        // Method (Behavior)
        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving at {Speed} mph.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating Car objects using the constructor
            Car car1 = new Car("Toyota", "Red", 60);
            Car car2 = new Car("BMW", "Blue", 80);

            // Using the method
            car1.Drive();  // Output: Toyota is driving at 60 mph.
            car2.Drive();  // Output: BMW is driving at 80 mph.
        }
    }

}
