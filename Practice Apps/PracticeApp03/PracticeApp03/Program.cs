using System;
using System.Globalization;

namespace PracticeApp02
{
    class Person
    {
        string personName = string.Empty;
        string personSurname = string.Empty;
        int personAge = 0;
        string personEmployed = string.Empty;
        int personSalary = 0;

        public Person(string inputpersonName, string inputpersonSurname, int inputpersonAge, string inputpersonEmployed, int inputpersonSalary)
        {
            this.personName = inputpersonName;
            this.personSurname = inputpersonSurname;
            this.personAge = inputpersonAge;
            this.personEmployed = inputpersonEmployed;
            this.personSalary = inputpersonSalary;
        }

        public void DisplayData()
        {
            string infoSentance = string.Empty;
            infoSentance += $"Firstname: {personName} {Environment.NewLine}";
            infoSentance += $"Surname: {personSurname} {Environment.NewLine}";
            infoSentance += $"Age: {personAge} {Environment.NewLine}";
            infoSentance += $"Employed: {personEmployed} {Environment.NewLine}";
            infoSentance += $"Salary: {personSalary}";

            Console.WriteLine(infoSentance);
        }
    }
    class Program
    {
        static void Main()
        {
            Person per01 = new Person("Dyl", "Sanam", 23, "Yes", 45000);
            Person per02 = new Person("Corn", "Stols", 43, "Yes", 50000);

            Console.WriteLine("=============================");
            Console.WriteLine("============WELCOME==========");
            Console.WriteLine("=============================");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Thank you for providing the information.");
            Console.WriteLine($"Your details are:{Environment.NewLine}");
            Console.WriteLine("-----------------");

            per01.DisplayData();

            Console.WriteLine("-----------------");

            per02.DisplayData();

            Console.WriteLine("-----------------");

        }
    }
}
