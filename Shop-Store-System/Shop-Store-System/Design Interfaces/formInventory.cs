﻿using Shop_Store_System.DataAccess;
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

        CategoryData categoryData = new CategoryData();
        ProductData productData = new ProductData();

        private void formInventory_Load(object sender, EventArgs e)
        {
            //Визуализация на категориите в комбо бокса
            DataTable categoriesDataTable = categoryData.Select();
            cmbCategories.DataSource = categoriesDataTable;

            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

            //Визуализация на всички продукти
            DataTable productDataTable = productData.Select();
            dgvProducts.DataSource = productDataTable;
            dgvProducts.Columns[0].HeaderText = "Product ID";
            dgvProducts.Columns[1].HeaderText = "Product Name";
            dgvProducts.Columns[2].HeaderText = "Category";
            dgvProducts.Columns[3].HeaderText = "Special Product Number";
            dgvProducts.Columns[4].HeaderText = "Description";
            dgvProducts.Columns[5].HeaderText = "Price";
            dgvProducts.Columns[6].HeaderText = "Quantity";
            dgvProducts.Columns[7].HeaderText = "Added Date";
            dgvProducts.Columns[8].HeaderText = "Added By ID";
            dgvProducts.Columns[9].HeaderText = "Added By Name";

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategories.Text;

            DataTable dt = productData.DisplayProductsByCategory(category);
            dgvProducts.DataSource = dt;
           
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = productData.Select();
            dgvProducts.DataSource = dt;
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                //Fetch the value of the second Column.
                int quantity = Convert.ToInt32(e.Value);

                //Apply Background color based on value.
                if (quantity < 5)
                {
                    dgvProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                if (quantity > 4)
                {
                    dgvProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}

