using System;
using Module01;
using Module03;

namespace Module02
{
    public class Car : Vehicle
    {
        private Engine engine; // Composition: Car "has a" Engine

        public Car() // ✅ Constructor initializes the Engine object
        {
            engine = new Engine();
        }

        public void StartEngine()
        {
            engine.Start();
        }
    }
}
