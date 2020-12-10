using Shop_Store_System.Design_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Store_System
{
    public partial class formUserDashboard : Form
    {
        public formUserDashboard()
        {
            InitializeComponent();
        }

        private void formUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void formUserDashboard_Load(object sender, EventArgs e)
        {
            labelLoggedUser.Text = formLogin.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDealerCustomer dealerAndCustomer = new formDealerCustomer();
            dealerAndCustomer.Show();
        }
    }
}
