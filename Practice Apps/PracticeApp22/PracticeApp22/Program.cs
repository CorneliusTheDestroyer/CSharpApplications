namespace PracticeApp22
{
    public class Animal
    {
        public virtual void MakeSounds()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSounds() 
        {
            base.MakeSounds();
            Console.WriteLine("Dog barks");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();

            myDog.MakeSounds();
        }
    }
}
