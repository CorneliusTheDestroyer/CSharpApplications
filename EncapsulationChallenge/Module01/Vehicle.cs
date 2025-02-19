using System;

namespace Module01
{
    public class Vehicle
    {
        public int Speed { get; set; } // Simple property, no constructor needed

        public void Move()
        {
            Console.WriteLine($"{GetType().Name} is moving at speed: {Speed} km/h");
        }
    }
}
