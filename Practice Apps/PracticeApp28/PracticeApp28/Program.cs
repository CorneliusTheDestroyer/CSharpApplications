namespace PracticeApp28
{
    internal abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Zzz...");
        }
    }

    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Animal animal = new Animal(); //Cant instantiate cause abstract class
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Sleep();
        }
    }
}
