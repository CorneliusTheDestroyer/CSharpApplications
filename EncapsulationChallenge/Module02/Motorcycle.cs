using System;
using Module01;
using Module03;

namespace Module02
{
    public class Motorcycle : Vehicle
    {
        private Engine engine; // Composition: Motorcycle "has an" Engine

        public Motorcycle()
        {
            engine = new Engine();
        }

        public void StartEngine()
        {
            engine.Start();
        }
    }
}
