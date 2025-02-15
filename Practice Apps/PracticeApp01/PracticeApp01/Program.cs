using System;

namespace PracticeApp01
{
    class Program
    {
        static void Main()
        {
            //char personInitials = '\0';
            string personName = string.Empty;
            string personSurname = string.Empty;
            int personAge = 0;
            string personEmployed = string.Empty;
            decimal personSalary = 0;   

            Console.WriteLine("=============================");
            Console.WriteLine("============WELCOME==========");
            Console.WriteLine("=============================");
            Console.WriteLine(Environment.NewLine);

            //Console.WriteLine("Please enter your initials: ");
            //personInitials = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please enter your First Name: ");
            personName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter your Last Name: ");
            personSurname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter you Age: ");
            personAge = Convert.ToInt32(Console.ReadLine());

            bool isAgeVerified = (personAge >= 18) ? true : false;

            if (isAgeVerified)
            {
                Console.WriteLine("Are you employed? ");
                personEmployed = Convert.ToString(Console.ReadLine());
            }

            bool isEmployed = (personEmployed == "yes") || (personEmployed == "Yes") ? true : false;

            if (isEmployed)
            {
                Console.WriteLine("What is your Salary? ");
                personSalary = Convert.ToDecimal(Console.ReadLine());
            }

            string infoSentance = string.Empty;
            //infoSentance += $"Initials: {personInitials} {Environment.NewLine}";
            infoSentance += $"Firstname: {personName} {Environment.NewLine}";
            infoSentance += $"Surname: {personSurname} {Environment.NewLine}";
            infoSentance += $"Age: {personAge} {Environment.NewLine}";
            
            if (isAgeVerified) 
            infoSentance += $"Employed: {isEmployed} {Environment.NewLine}";

            if (isEmployed)
            infoSentance += $"Salary: {personSalary}";
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Thank you for providing the information.");
            Console.WriteLine($"Your details are:{Environment.NewLine}");
            Console.WriteLine("-----------------");
            Console.WriteLine(infoSentance);
            Console.WriteLine("-----------------");

        }
    }
}
