namespace PracticeApp24
{
    public class Vehicle
    {
        protected int Id { get; set; }
        public string? Name { get; set; }

        public Vehicle(int id, string name)
        {
            Id = id;
            Name = name;

            Console.WriteLine("Vehicle created.");
        }

        public virtual void ShowMessage()
        {
            Console.WriteLine("This is a new Vehicle.");
        }
    }

    public class Car : Vehicle
    {
        public string? Make { get; set; }
        public string? Model { get; set; }

        public Car(int id, string name, string make, string model) : base(id, name) 
        {
            Make = make;
            Model = model;

            Console.WriteLine("Car created.");
        }

        public override void ShowMessage() 
        {
            Console.WriteLine("This is a new Car.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle myVehicle = new Vehicle(01, "BMW");
            Car myCar = new Car(01, "BMW", "Hatchback", "Sports CI");

            //myVehicle.ShowMessage();
            myCar.ShowMessage();

            Console.WriteLine($"Car details - Name: {myCar.Name}, Make: {myCar.Make}, Model: {myCar.Model}");
        }
    }
}
