using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMapplication
{
    public partial class Login : Form
    {

        private readonly ATMEntities atmEntities;
        public Login()
        {
            InitializeComponent();
            atmEntities = new ATMEntities();
        }

        private void MainTitle_Load(object sender, EventArgs e)
        {

        }

        private void CardNumberSubmitBTN_Click(object sender, EventArgs e)
        {
            try
            {

                var enteredCard = Convert.ToInt32(Cardtext.Text);
                var enteredPIN = Convert.ToInt32(PINtext.Text);

                var user = atmEntities.Cards.FirstOrDefault(q => q.CardNumber == enteredCard && q.PIN == enteredPIN);
                    if (user == null)
                    {
                    MessageBox.Show("Please provide a valid Card and PIN number! ");
                    }
                    else 
                    {
                    MessageBox.Show("You have successfully logged in! You are not great but okay.");
                    var mainMenu = new MainMenu(this);
                    mainMenu.Show();
                    Hide();

                    }
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong");
            }
        }
    }
}
