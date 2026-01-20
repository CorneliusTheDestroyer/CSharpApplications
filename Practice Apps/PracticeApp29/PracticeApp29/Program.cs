namespace PracticeApp29
{
    public interface IAnimal
    {
        void MakeSound();

        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Barks");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Dog ate {food}");
        }
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meeoow!!");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Cat ate {food}");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("Treat");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("Fish");
        }
    }
}
