using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp08
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate) : base(owner + " (" + interestRate + "%)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Deposit amount must be positive.";
            if (amount > 10000)
                return "Deposit amount exceeds the limit of $10,000.";

            decimal interestAmount = amount * (InterestRate / 100);
            Balance += amount + interestAmount;
            return $"Deposited {amount:C} to account {AccountNumber}. New balance: {Balance:C} (including interest: {InterestRate:C})";
        }
    }
}
