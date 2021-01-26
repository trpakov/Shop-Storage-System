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
    public partial class formUserDashboard : Form
    {
        public formUserDashboard()
        {
            InitializeComponent();
            lowQuantityProducts.Hide();
            ShowLowQuantity();
        }
        ProductData productData = new ProductData();
        public static string transactionType;

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

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Purchase";
            formPurchaseSales purchase = new formPurchaseSales();
            purchase.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Sales";
            formPurchaseSales sales = new formPurchaseSales();
            sales.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInventory inventory = new formInventory();
            inventory.Show();
        }

        private void logisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDelivery logistic = new formDelivery();
            logistic.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        public void ShowLowQuantity()
        {
            DataTable dt = productData.DisplayProductsByLowQuantity();
            lowQuantityProducts.DataSource = dt;
            if (lowQuantityProducts.Rows.Count != 0)
            {
                tableLabel.Text = "Products in low quantity:";       
                lowQuantityProducts.Show();
                lowQuantityProducts.Columns[0].Visible = false;
                lowQuantityProducts.Columns[1].HeaderText = "Product Name";
                lowQuantityProducts.Columns[2].HeaderText = "Category";
                lowQuantityProducts.Columns[3].HeaderText = "Special Product Number";
                lowQuantityProducts.Columns[4].HeaderText = "Description";
                lowQuantityProducts.Columns[5].HeaderText = "Price";
                lowQuantityProducts.Columns[6].HeaderText = "Quantity";
                lowQuantityProducts.Columns[7].HeaderText = "Added Date";
                lowQuantityProducts.Columns[8].Visible = false;
                lowQuantityProducts.Columns[9].HeaderText = "Added By Name";
            }
            
        }
    }
}
