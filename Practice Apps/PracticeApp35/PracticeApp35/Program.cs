using System.Threading.Channels;

namespace PracticeApp35
{
    public interface IEmployee
    {
        void Task();
    }

    public class Programmer : IEmployee
    {
        public void Task() 
        {
            Console.WriteLine("Employee does Programming.");
        }
    }

    public class Manager : IEmployee
    {
        public void Task()
        {
            Console.WriteLine("Employee manages other employees.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee programmer = new Programmer();

            programmer.Task();

            IEmployee manager = new Manager();

            manager.Task();
        }
    }
}
