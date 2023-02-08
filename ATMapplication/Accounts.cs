using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMapplication
{
    public partial class Accounts : Form
    {
        private readonly MainMenu _mainmenu;
        public Customer _Customer;
        private Customer customer;
        private Account custAccount;
        private string _CustFirstName;
        private readonly ATMEntities atmEntities;

        public Accounts(MainMenu mainMenu, Customer customer, Account custAccount)
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

        public MainMenu MainMenu { get; }

        private void AccountCheckingBTN_Click(object sender, EventArgs e)
        {
            var checkbalance = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Checking");
            if (checkbalance == null)
            {
                MessageBox.Show("There is no Chekcing Account associated with this card number! ");
            }
            else
            {
                MessageBox.Show("Your Checking Account balance is: $" + checkbalance.Balance);
            }
    
        }

        private void AccountsSavingBTN_Click(object sender, EventArgs e)
        {
            var savebalance = atmEntities.Accounts.FirstOrDefault(q => q.Type == "Savings");
            if (savebalance == null)
            {
                MessageBox.Show("There is no Chekcing Account associated with this card number! ");
            }
            else
            {
                MessageBox.Show("Your Checking Account balance is: $" + savebalance.Balance);
            }
        }
    }
}
