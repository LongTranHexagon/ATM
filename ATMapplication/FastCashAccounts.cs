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
        private readonly ATMEntities atmEntities;
        public FastCashAccounts(MainMenu mainMenu, Customer customer, Account custAccount)
        {
            InitializeComponent();
            MainMenu = mainMenu;
            this.customer = customer;
            this.custAccount = custAccount;
            _CustFirstName = customer.FirstName;
            FastCashCustomerLabel.Text = "Hello " + _CustFirstName;

        }

        private void FastCash_Load(object sender, EventArgs e)
        {

        }

        private void FastCashCheckingBTN_Click(object sender, EventArgs e)
        {
            var FastCashChecking = new FastCashChecking(this, customer, account);
            FastCashChecking.Show();
            Hide();
        }

        private void FastCashSavingBTN_Click(object sender, EventArgs e)
        {
            var fastCashSavings = new FastCashSavings(this, customer, account);
            fastCashSavings.Show();
            Hide();
        }
    }
}
