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

    public class WorkProcess
    {
        private readonly IEmployee _employee;

        public WorkProcess(IEmployee employee)
        {
            _employee = employee;
        }

        public void DoTask()
        {
            _employee.Task();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee programmer = new Programmer();
            WorkProcess workProcess = new WorkProcess(programmer);
            workProcess.DoTask();

            IEmployee manager = new Manager();
            workProcess = new WorkProcess(manager);
            workProcess.DoTask();
        }
    }
}
