namespace PracticeApp25
{
    internal class Animal
    {
        public void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    internal class Dog : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Speak();

            Dog myDog = new Dog();
            myDog.Speak();

            Animal myPet = new Dog();
            myPet.Speak();
        }
    }
}
