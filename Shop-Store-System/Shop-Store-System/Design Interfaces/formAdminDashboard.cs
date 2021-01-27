using Shop_Store_System.DataAccess;
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
    public partial class formAdminDashboard : Form
    {
        public formAdminDashboard()
        {
            InitializeComponent();
            //A
            dataGridViewLowQuantity.Hide();
            ShowLowQuantity();
            //
        }
        ProductData productData = new ProductData();
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsers user = new formUsers();
            user.Show();
        }

        private void formAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void formAdminDashboard_Load(object sender, EventArgs e)
        {
            labelLoggedUser.Text = formLogin.loggedIn;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategories category = new formCategories();
            category.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProducts product = new formProducts();
            product.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDealerCustomer dealerAndCustomer = new formDealerCustomer();
            dealerAndCustomer.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTransactions transaction = new formTransactions();
            transaction.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInventory inventory = new formInventory();
            inventory.Show();
        }

        private void logisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogistic logistic = new formLogistic();
            logistic.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formArchiveDeliveries archive = new formArchiveDeliveries();
            archive.Show();
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOrderReference refForm = new formOrderReference();
            refForm.Show();
        }
        //A
        public void ShowLowQuantity()
        {
            DataTable dt = productData.DisplayProductsByLowQuantity();
            dataGridViewLowQuantity.DataSource = dt;
            if (dataGridViewLowQuantity.Rows.Count != 0)
            {
                tableLabel.Text = "Products in low quantity:";
                dataGridViewLowQuantity.Show();
                dataGridViewLowQuantity.Columns[0].Visible = false;
                dataGridViewLowQuantity.Columns[1].HeaderText = "Product Name";
                dataGridViewLowQuantity.Columns[2].HeaderText = "Category";
                dataGridViewLowQuantity.Columns[3].HeaderText = "Special Product Number";
                dataGridViewLowQuantity.Columns[4].HeaderText = "Description";
                dataGridViewLowQuantity.Columns[5].HeaderText = "Price";
                dataGridViewLowQuantity.Columns[6].HeaderText = "Quantity";
                dataGridViewLowQuantity.Columns[7].HeaderText = "Added Date";
                dataGridViewLowQuantity.Columns[8].Visible = false;
                dataGridViewLowQuantity.Columns[9].HeaderText = "Added By Name";
            }
        }
    }
}
