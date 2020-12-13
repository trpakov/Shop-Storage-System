using Shop_Store_System.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Store_System.Design_Interfaces
{
    public partial class formInventory : Form
    {
        public formInventory()
        {
            InitializeComponent();
        }

        categoriesDataAccess cdal = new categoriesDataAccess();
        productsDataAccess pdal = new productsDataAccess();

        private void formInventory_Load(object sender, EventArgs e)
        {
            //Визуализация на категориите в комбо бокса
            DataTable categoriesDataTable = cdal.Select();
            cmbCategories.DataSource = categoriesDataTable;

            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

            //Визуализация на всички продукти
            DataTable productDataTable = pdal.Select();
            dgvProducts.DataSource = productDataTable;
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategories.Text;

            DataTable dt = pdal.DisplayProductsByCategory(category);
            dgvProducts.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }
    }
}
