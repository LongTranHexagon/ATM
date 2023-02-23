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
    public partial class FastCashChecking : Form
    {
        private Customer customer;
        private Account custAccount;
        private string _custFirstName;
        private string _AccountType;
        private decimal _AccountBalance;
        private FastCashAccounts fastCashAccounts;
        private object account;
        private readonly ATMEntities atmEntities;
        public FastCashChecking(FastCashAccounts fastCashAccounts, Customer customer, object account)
        {
            InitializeComponent();
            this.fastCashAccounts = fastCashAccounts;
            this.customer = customer;
            this.account = account;
            atmEntities = new ATMEntities();
    //        _AccountType = custAccount.Type;
     //       _AccountBalance = custAccount.Balance;
            _custFirstName = customer.FirstName;
            FastCashCheckCustNameLB.Text = "Hello " + _custFirstName;
     //       FastCashCheckAccountInfoLB.Text = _AccountType + "balance: $" + _AccountBalance;
        }

        private void FastCashChecking_Load(object sender, EventArgs e)
        {

        }

        private void FastCashCheck20BTN_Click(object sender, EventArgs e)
        {

        }

        private void FastCashCheck40BTN_Click(object sender, EventArgs e)
        {

        }

        private void FastCashCheck60BTN_Click(object sender, EventArgs e)
        {

        }

        private void FastCashCheck80BTN_Click(object sender, EventArgs e)
        {

        }

        private void FastCashCheck100BTN_Click(object sender, EventArgs e)
        {

        }

        private void FastCashCheck200BTN_Click(object sender, EventArgs e)
        {

        }

        private void FastCashCheckMenuBTN_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu(this, customer, custAccount);
            mainMenu.Show();
            Hide();
        }
    }
}
