using System;

namespace EmployeeApplication
{
    class Program
    {
        static void Main()
        {
            int employeeId = 0;
            string firstName = "Cornelius";
            string lastName = string.Empty;
            decimal annualSalary = 0;
            char gender;
            bool isManager = false;

            Console.WriteLine("Please enter the employee's Id");

            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the employee's annual salary");
            
            annualSalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the employee's gender (f/m)");

            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The employee is a manager (t/f)");

            isManager = Convert.ToBoolean(Console.ReadLine());

            string genderTerm = (gender == 'f') ? "female" : "male";

            string managerNarrative = (isManager) ? "part of the management team" : "currently not part of the management team";

            string narrative = $"Employee with an Id of {employeeId} ";
            narrative += $"who's full name is {firstName} {lastName} {Environment.NewLine}";
            narrative += $"is a {genderTerm} employee who is {managerNarrative} {Environment.NewLine}";
            narrative += $"This employee earns an annual salary of {annualSalary} pounds.";

            Console.Clear();

            Console.WriteLine(narrative);

            Console.ReadLine();

        }
    }
}
