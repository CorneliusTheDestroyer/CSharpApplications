using System;
using Module01;
using Module02;
using Module03;

namespace EncapsulationChallenge
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Speed = 60;
            car.Move();
            car.StartEngine();

            //Car car2 = new Car();
            //car2.Speed = 90;
            //car2.Move();

            Bicycle bicycle = new Bicycle();
            bicycle.Speed = 15;
            bicycle.Move();
            bicycle.RingBell();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Speed = 130;
            motorcycle.Move();
            motorcycle.StartEngine();
        }
    }
}
