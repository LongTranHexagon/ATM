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
    public partial class Register : Form
    {
        private readonly ATMEntities atmEntities;
        public Register()
        {
            InitializeComponent();
            atmEntities = new ATMEntities();
        }

        private void RegisterSubmitBTN_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
