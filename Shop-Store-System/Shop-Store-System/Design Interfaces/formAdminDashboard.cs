﻿using Shop_Store_System.Design_Interfaces;
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
    public partial class formAdminDashboard : Form
    {
        public formAdminDashboard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsers user = new formUsers();
            user.Show();
        }
    }
}