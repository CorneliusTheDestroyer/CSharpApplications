namespace PracticeApp08
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

            //BankAccount bankAccount = new BankAccount("John Doe");
            ////bankAccount.Owner = "John Doe";
            ////bankAccount.AccountNumber = Guid.NewGuid();
            ////bankAccount.Balance = 1000.00m;

            //BankAccount bankAccount2 = new BankAccount("Pieter");
            ////bankAccount2.Owner = "Pieter";
            ////bankAccount2.AccountNumber = Guid.NewGuid();
            ////bankAccount2.Balance = 2000.00m;

            //BankAccount bankAccount3 = new BankAccount("Billy");
            ////bankAccount3.Owner = "Billy";
            ////bankAccount3.AccountNumber = Guid.NewGuid();
            ////bankAccount3.Balance = 500.00m;

            //List<BankAccount> bankAccounts = new List<BankAccount>();
            //bankAccounts.Add(bankAccount);
            //bankAccounts.Add(bankAccount2);
            //bankAccounts.Add(bankAccount3);

            //gridAccount.DataSource = BankAccounts;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbOwner.Text))
                return;
        
            BankAccount bankAccount = new BankAccount(tbOwner.Text);
            BankAccounts.Add(bankAccount);

            RefreshGrid();
            tbOwner.Clear();
        }

        private void RefreshGrid()
        {
            gridAccount.DataSource = null;
            gridAccount.DataSource = BankAccounts;
        }
    }
}
