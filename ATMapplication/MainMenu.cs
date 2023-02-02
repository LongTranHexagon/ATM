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
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(Login login)
        {
            InitializeComponent();
            _login = login;
        }

        private void MainOptions_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
