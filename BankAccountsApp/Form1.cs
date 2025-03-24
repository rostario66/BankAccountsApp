namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                MessageBox.Show("Name field cannot be empty");

            if (InterestRateNum.Value > 0)
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));
            else
                BankAccounts.Add(new BankAccount(OwnerTxt.Text));
            
            RefreshGrid();
            OwnerTxt.Text = string.Empty;
            InterestRateNum.Value = 0;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = string.Empty;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.
                    SelectedRows[0].DataBoundItem as BankAccount;
                
                MessageBox.Show(selectedBankAccount.Deposit(AmountNum.Value));
                AmountNum.Value = 0;
                RefreshGrid();
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.
                    SelectedRows[0].DataBoundItem as BankAccount;

                MessageBox.Show(selectedBankAccount.Withdraw(AmountNum.Value));
                RefreshGrid();
            }
        }
    }
}
