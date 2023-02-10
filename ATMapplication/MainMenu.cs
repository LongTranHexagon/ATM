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
    public partial class MainMenu : Form
    {
        private readonly Login _login;
        public Customer _Customer;
        public string _CustFirstName;
        public string _CustLastName;
        private Account _CustAccount;
        private Accounts accounts;

        public MainMenu(Login login, Customer customer, ICollection<Account> custAccount)
        {
            InitializeComponent();
            _login = login;
            _Customer = customer;
            _CustFirstName = customer.FirstName;
            _CustLastName = customer.LastName;
            //There is a bug where the last name has many white spaces in the texbox.
            MainMenuCustNameLB.Text = "Hello " + _CustFirstName; 
        }

        public MainMenu()
        {

        }

        public MainMenu(Accounts accounts)
        {
            this.accounts = accounts;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void MainMenuBalanceBTN_Click(object sender, EventArgs e)
        {
            var accounts = new Accounts(this, _Customer, _CustAccount);
            accounts.Show();
            Hide();
        }

        private void MainMenuFastCashBTN_Click(object sender, EventArgs e)
        {
            var fastcashaccounts = new FastCashAccounts(this, _Customer, _CustAccount);
            fastcashaccounts.Show();
            Hide();
        }
    }
}
