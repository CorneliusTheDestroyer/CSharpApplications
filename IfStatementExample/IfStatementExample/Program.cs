
using System;

namespace IfStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal moneyAmountInSavingsAccount = 300;
            decimal costOfBicycle = 1000;
            bool canGetLoan = true;
            decimal maxLoanAmount = 100;

            if (moneyAmountInSavingsAccount >= costOfBicycle)
            {
                Console.WriteLine("I have enough money to buy the bicycle");
            }
            else if (canGetLoan && moneyAmountInSavingsAccount + maxLoanAmount >= costOfBicycle)
            {
                Console.WriteLine("I do not have enough money in my savings account to buy the bicycle");
                Console.WriteLine("If I get a loan I will have enough money to buy the bicycle");
            }
            else if (canGetLoan && moneyAmountInSavingsAccount + maxLoanAmount >= costOfBicycle * 0.9m)
            {
                Console.WriteLine("I have over 90% of the money I need to buy the bicycle");
            }
            else if (canGetLoan && moneyAmountInSavingsAccount + maxLoanAmount > costOfBicycle / 2)
                Console.WriteLine("I have over half the money I need to buy the bicycle");
            else
            {
                Console.WriteLine("I do not have enough money to buy the bicycle");
            }

            Console.ReadKey();

        }
    }
}
