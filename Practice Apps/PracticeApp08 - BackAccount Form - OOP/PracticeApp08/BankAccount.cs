using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp08
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0.00m;
        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Deposit amount must be positive.";
            if (amount > 10000)
                return "Deposit amount exceeds the limit of $10,000.";
            
            Balance += amount;
            return $"Deposited {amount:C} to account {AccountNumber}. New balance: {Balance:C}";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You can not withdraw $" + amount;
            if (amount > Balance)
                return "You don't have enough money.";

            Balance -= amount;
            return $"Withdrew {amount:C} from account {AccountNumber}. New balance: {Balance:C}";
        }
    }
}
