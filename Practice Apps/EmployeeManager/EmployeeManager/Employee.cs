using System;

namespace EmployeeManager;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name)
    {
        Id = Guid.NewGuid().GetHashCode();
        Name = name;
        Position = "Employee";
        Salary = 0.0m;
    }

    public override string ToString()
    {
        return $"{Id}: {Name}, {Position}, ${Salary}";
    }

}
