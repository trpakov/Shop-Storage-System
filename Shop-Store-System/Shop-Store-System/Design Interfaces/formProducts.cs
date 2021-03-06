﻿using Shop_Store_System.BusinesLogic;
using Shop_Store_System.BusinessLogic;
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
    public partial class formProducts : Form
    {
        public formProducts()
        {
            InitializeComponent();
        }

        CategoryData categoryData = new CategoryData();
        Product product = new Product();
        ProductData productData = new ProductData();
        UserData userData = new UserData();

        private void formProducts_Load(object sender, EventArgs e)
        {
            //Създаване на таблица за взимане на данните от категориите
            DataTable categoriesDT = categoryData.Select();

            //Зареждане на категориите в комбо бокса
            cmbCategory.DataSource = categoriesDT;

            //Задаване на display and value member
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable dt = productData.Select();
            dgvProducts.DataSource = dt;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                product.Rate = decimal.Parse(txtRate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please add valid price!");
                return;
            }

            try
            {
                product.Name = txtName.Text;
                product.Category = cmbCategory.Text;
                product.SpecialNumber = txtSpecialNumber.Text;
                product.Description = txtDescription.Text;
                product.Quantity = 0;
                product.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
            

            //Вземане на името и id на влезналия потребител
            string loggedUsr = formLogin.loggedIn;
            User user = userData.GetIDFromUsername(loggedUsr);

            product.AddedBy = user.Id;
            product.AddedByName = loggedUsr;

            bool success = productData.Insert(product);

            if (success == true)
            {
                MessageBox.Show("Product Added Successfully.");

                Clear();

                DataTable dt = productData.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Add New Product.");
            }
        }

        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
            txtSpecialNumber.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Променлива за запазване на номера на селектирания ред
            int rowIndex = e.RowIndex;

            txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtSpecialNumber.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            product.Id = int.Parse(txtID.Text);

            try
            {
                product.Rate = decimal.Parse(txtRate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please add valid price!");
                return;
            }

            try
            {
                product.Name = txtName.Text;
                product.Category = cmbCategory.Text;
                product.SpecialNumber = txtSpecialNumber.Text;
                product.Description = txtDescription.Text;
                product.Quantity = 0;
                product.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            string loggedUsr = formLogin.loggedIn;
            User user = userData.GetIDFromUsername(loggedUsr);

            product.AddedBy = user.Id;
            product.AddedByName = loggedUsr;

            bool success = productData.Update(product);

            if (success == true)
            {
                MessageBox.Show("Product Successfully Updated.");

                Clear();

                DataTable dt = productData.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Product.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            product.Id = int.Parse(txtID.Text);

            bool success = productData.Delete(product);

            if (success == true)
            {
                MessageBox.Show("Product successfully deleted.");

                Clear();

                DataTable dt = productData.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Product.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                //Визуализация на търсения продукт
                DataTable dt = productData.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Визуализация на всички продукти
                DataTable dt = productData.Select();
                dgvProducts.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
