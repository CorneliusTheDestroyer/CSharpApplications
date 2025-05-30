using EmployeeManager;

internal class Program
{
    static List<Employee> employeeList = new List<Employee>();

    private static void Main(string[] args)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Welcome to Employee Manager!");

        bool running = true;

        while (running)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1 - View Employees");
            Console.WriteLine("2 - Add Employee");
            Console.WriteLine("3 - Update Employee");
            Console.WriteLine("4 - Remove Employee");
            Console.WriteLine("5 - Exit Application");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    ViewEmployees();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Please enter Employee name: ");
                    string newEmployee = Console.ReadLine();

                    AddEmployee(newEmployee);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Please enter Employee name: ");
                    string updateEmployee = Console.ReadLine();

                    UpdateEmployee(updateEmployee);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Please enter Employee name: ");
                    string deleteEmployee = Console.ReadLine();

                    DeleteEmployee(deleteEmployee);
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

    public static void AddEmployee(string name)
    {
        employeeList.Add(new Employee(name));
    }

    public static void ViewEmployees()
    {
        if (employeeList.Count != 0)
        {
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
            }
        }
        else
            Console.WriteLine("No Eployees available.");
    }

    public static void UpdateEmployee(string name)
    {
        foreach (var employee in employeeList)
        {
            if (name == employee.Name)
            {
                Console.Write("Please update Employee Salary: ");
                var salaryUpdate = Console.ReadLine();

                if (decimal.TryParse(salaryUpdate, out decimal newSalary))
                {
                    employee.Salary = newSalary;
                    Console.WriteLine("Salary Updated successfully");
                }
                else
                {
                    Console.WriteLine("Invalid Salary input.");
                }
            }
        }
    }

    public static void DeleteEmployee(string name)
    {
        for (int i = employeeList.Count - 1; i >= 0; i--)
        {
            if (employeeList[i].Name == name)
                employeeList.RemoveAt(i);
            else
                Console.WriteLine("Employee does not exists!");
        }
    }

    public static void Exit()
    {
        Console.WriteLine("CLosing Application.");
    }
}