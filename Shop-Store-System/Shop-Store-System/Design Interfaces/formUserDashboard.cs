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
            this.Hide();
        }
    }
}
