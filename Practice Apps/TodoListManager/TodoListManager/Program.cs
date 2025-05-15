using System.Diagnostics;
using TodoListManager;

class Program
{
    static List<ToDoTask> TaskList = new List<ToDoTask>();
    static void Main(string[] args)
    {
        bool running = true;

        Console.WriteLine("================================");
        Console.WriteLine("Welcome to the ToDo List Manager");
        Console.WriteLine("================================");

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Please select on of the options:");
            Console.WriteLine("1 - View Task");
            Console.WriteLine("2 - Add Task");
            Console.WriteLine("3 - Mark Task as Completed");
            Console.WriteLine("4 - Remove Task");
            Console.WriteLine("5 - Exit application");
            Console.WriteLine();

            string options = Console.ReadLine();

            switch (options)
            {
                case "1":
                    Console.Clear();
                    ViewTasks();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Please enter a name for your task: ");
                    string newTask = Console.ReadLine();

                    AddTask(newTask);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Please enter a name of the task you want to mark as Completed: ");
                    string completedTask = Console.ReadLine();

                    MarkTaskComplete(completedTask);
                    break;
                case "4":
                    Console.Clear();
                    Console.Write("Please enter a name of the task you want to remove: ");
                    string removeTask = Console.ReadLine();

                    DeleteTask(removeTask);
                    break;
                case "5":
                    Console.Clear();
                    Exit();
                    running = false;
                    break;
                default:
                    break;
            }
        }
    }
    static void AddTask(string title)
    {
        TaskList.Add(new ToDoTask(title));
    }

    static void ViewTasks() 
    {
        if (TaskList.Count != 0)
        {
            foreach (var task in TaskList)
            {
                Console.WriteLine(task.ToString());
            }
        }
        else
        {
            Console.WriteLine("No tasks available.");
        }
    }

    static void MarkTaskComplete(string title) 
    {
        foreach (var task in TaskList)
        {
            if (title == task.Title) 
                task.IsCompleted = true;
        }
    }

    static void DeleteTask(string title) 
    {
        for (int i = TaskList.Count - 1; i >= 0; i--) 
        {
            if (TaskList[i].Title == title)
                TaskList.RemoveAt(i);
        }
    }

    static void Exit() 
    {
        Console.WriteLine("Application closing.");
    }
}
