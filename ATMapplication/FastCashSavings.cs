﻿using System;
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
    public partial class FastCashSavings : Form
    {
        private readonly Customer customer;
        private ICollection<Account> custAccount;

        public FastCashSavings()
        {
            InitializeComponent();
            /*var CustomerFirst = customer.FirstName;
            FastCashCheckAccountInfoLB.Text = "Hello " + CustomerFirst;*/
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
