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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void CardNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccountCheckingBTN_Click(object sender, EventArgs e)
        {
            var checkBalance = new CheckBalance();
            checkBalance.Show();
            Hide();
        }

        private void AccountsSavingBTN_Click(object sender, EventArgs e)
        {
            var savingBalance = new SavingBalance();
            savingBalance.Show();
            Hide();
        }
    }
}
