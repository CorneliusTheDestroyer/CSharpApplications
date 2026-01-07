namespace PracticeApp26
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public virtual void ShowMessage()
        {
            Console.WriteLine("Test Message 01");
        }
    }

    public class Car : Vehicle
    {
        public string? Make { get; set; }
        public string? Model { get; set; }

        public override sealed void ShowMessage()
        {
            Console.WriteLine("Test Message 02");
        }
    }

    public class Bike : Car
    {
        public int BikeId { get; set; }

        public override void ShowMessage() //Error because sealed method in Car class
        {
            Console.WriteLine("Test Message 03");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.ShowMessage();

            Car car = new Car();

            car.ShowMessage();

            Bike bike = new Bike();

            bike.ShowMessage();
        }
    }
}
