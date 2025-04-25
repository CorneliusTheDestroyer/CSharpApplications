namespace PracticeApp08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "John Doe";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 1000.00m;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Pieter";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 2000.00m;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Billy";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 500.00m;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            gridAccount.DataSource = bankAccounts;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

        }
    }
}
