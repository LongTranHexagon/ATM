using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMapplication
{
    public partial class FastCashAccounts : Form
    {
        private readonly MainMenu _mainmenu;
        public Customer _Customer;
        private MainMenu MainMenu;
        private Customer customer;
        private Account custAccount;
        private string _CustFirstName;
        private object _CustAccount;
        private object fastCashChecking;
        private object account;
        private object custaccount;
        private readonly ATMEntities atmEntities;
        public FastCashAccounts(MainMenu mainMenu, Customer customer, Account custAccount)
        {
            InitializeComponent();
            MainMenu = mainMenu;
            this.customer = customer;
            this.custAccount = custAccount;
            _CustFirstName = customer.FirstName;
            atmEntities = new ATMEntities();
            FastCashCustomerLabel.Text = "Hello " + _CustFirstName;

        }

        private void FastCash_Load(object sender, EventArgs e)
        {

        }

        private void FastCashCheckingBTN_Click(object sender, EventArgs e)
        {
            //Only pulls up the first Checking account information.
            var checkFastCash = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Checking");
            if (checkFastCash == null)
            {
                MessageBox.Show("There is no Checking Account associated with this card number! ");
            }
            else
            {
                var FastCashChecking = new FastCashChecking(this, customer, custAccount);
                FastCashChecking.Show();
                Hide();
                MessageBox.Show(checkFastCash.Type + "Account #" + checkFastCash.AccountID + "\n" + "Your Checking Account balance is: $" + checkFastCash.Balance);
            }
        }

        private void FastCashSavingBTN_Click(object sender, EventArgs e)
        {
            var saveFastCash = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Savings");
            if (saveFastCash == null)
            {
                MessageBox.Show("There is no Savings Account associated with this card number! ");
            }
            else
            {
                var fastCashSavings = new FastCashSavings(this, customer, account);
                fastCashSavings.Show();
                Hide();
                MessageBox.Show(saveFastCash.Type + "Account #" + saveFastCash.AccountID + "\n" + "Your Savings Account balance is: $" + saveFastCash.Balance);
            }
        }
    }
}
