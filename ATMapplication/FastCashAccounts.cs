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
        private readonly ATMEntities atmEntities;
        public FastCashAccounts(MainMenu mainMenu, Customer customer, Account custAccount)
        {
            InitializeComponent();
            MainMenu = mainMenu;
            this.customer = customer;
            this.custAccount = custAccount;
            _CustFirstName = customer.FirstName;
            atmEntities = new ATMEntities();
            //Bug: It does show the customer's first name but there is so much whitespace, it does not show the name
            AccountCustomerLabel.Text = "Hello " + _CustFirstName;
        }

        private void FastCash_Load(object sender, EventArgs e)
        {

        }

        private void FastCashCheckingBTN_Click(object sender, EventArgs e)
        {
            var FastCashCheckingVerify = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Checking");
            if (FastCashCheckingVerify == null)
            {
                MessageBox.Show("There is no Checking Account associated with this card number! ");
            }
            else
            {
                // Button not working. Showing a blank screen.
                var FastCashChecking = new FastCashChecking(this, _Customer, _CustAccount);
                FastCashChecking.Show();
                Hide();
            }
        }

        private void FastCashSavingBTN_Click(object sender, EventArgs e)
        {
            var FastCashSavingsVerify = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Savings");
            if (FastCashSavingsVerify == null)
            {
                MessageBox.Show("There is no Savings Account associated with this card number! ");
            }
            else
            {
                /*var FastCashSavings = new FastCashSavings(this, _Customer, _CustAccount);
                FastCashSavings.Show();
                Hide();*/
            }
        }
    }
}
