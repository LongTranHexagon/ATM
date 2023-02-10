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
        private readonly MainMenu _mainmenu;
        public Customer _Customer;
        private MainMenu MainMenu;
        private Customer customer;
        private Account custAccount;
        private string _CustFirstName;
        private FastCashAccounts fastCashAccounts;
        private object custAccount1;
        private object custAccount2;
        private object custAccount3;
        private readonly ATMEntities atmEntities;
        public FastCashChecking(MainMenu mainMenu, Customer customer, Account custAccount)
        {
            InitializeComponent();
            MainMenu = mainMenu;
            this.customer = customer;
            this.custAccount = custAccount;
            _CustFirstName = customer.FirstName;
            atmEntities = new ATMEntities();
            //Bug: It does show the customer's first name but there is so much whitespace, it does not show the name
            FastCashCheckCustNameLB.Text = "Hello " + _CustFirstName;
        }

        public FastCashChecking(FastCashAccounts fastCashAccounts, Customer customer, object custAccount3)
        {
            this.fastCashAccounts = fastCashAccounts;
            this.customer = customer;
            this.custAccount3 = custAccount3;
        }

        private void FastCashChecking_Load(object sender, EventArgs e)
        {
            var CheckAccountLB = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Checkings");
            FastCashCheckAccountInfoLB.Text = CheckAccountLB.Type + " " + CheckAccountLB.Balance;
        }

        private void FastCashCheck20BTN_Click(object sender, EventArgs e)
        {
            var fastCashChecking = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Checking");
            if (fastCashChecking == null)
            {
                MessageBox.Show("There is no Checking Account associated with this card number! ");
            }
            else
            {
                if (fastCashChecking.Balance < 20)
                {
                    MessageBox.Show("Dispensing $20...");
                }
                else 
                {
                    MessageBox.Show("Insufficent Funds... ");
                }
            }
        }
    }
}
