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
        private readonly ICollection<Account> custAccount;

        public FastCashChecking()
        {
            InitializeComponent();
           // var accountNameAndNumber = FastCashCheckAccountInfoLB(Accounttype + AccountNumber)
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
