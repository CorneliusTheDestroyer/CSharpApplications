namespace PracticeApp27
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual void ShowMessage()
        {
            Console.WriteLine("Message 01");
        }
    }

    public class Car : Vehicle
    {
        public string? Make { get; set; }
        public string? Model { get; set; }

        public override void ShowMessage()
        {
            base.ShowMessage();
            Console.WriteLine("Message 02");
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
        }
    }
}
