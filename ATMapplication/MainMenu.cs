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
        private BalanceAccounts accounts;
        private FastCashChecking fastCashChecking;
        private object customer;
        private object custAccount;
        private BalanceAccounts balanceAccounts;

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

        public MainMenu(FastCashChecking fastCashChecking, object customer, object custAccount)
        {
            InitializeComponent();
            this.fastCashChecking = fastCashChecking;
            this.customer = customer;
            this.custAccount = custAccount;
        }

        public MainMenu(BalanceAccounts balanceAccounts, Customer customer, Account custAccount)
        {
            InitializeComponent();
            this.balanceAccounts = balanceAccounts;
            this.customer = customer;
            this.custAccount = custAccount;
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
            var balanceAccounts = new BalanceAccounts(this, _Customer, _CustAccount);
            balanceAccounts.Show();
            Hide();
        }

        private void MainMenuFastCashBTN_Click(object sender, EventArgs e)
        {
            var fastCashAccounts = new FastCashAccounts();
            fastCashAccounts.Show();
            Hide();
        }
    }
}
