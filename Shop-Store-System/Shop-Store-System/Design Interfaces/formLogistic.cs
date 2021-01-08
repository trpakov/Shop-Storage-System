using Shop_Store_System.BusinesLogic;
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
    public partial class formLogistic : Form
    {
        public formLogistic()
        {
            InitializeComponent();
        }

        userDataAccess userDataAccess = new userDataAccess();
        logisticBusinessLogic logistic = new logisticBusinessLogic();
        logisticDataAccess logisticDataAccess = new logisticDataAccess();
        productsDataAccess productDataAccess = new productsDataAccess();

        DataTable transactionTable = new DataTable();

        string description = null;

        private void formLogistic_Load(object sender, EventArgs e)
        {
            //Създаване на таблица за взимане на данните от категориите
            DataTable logisticDT = userDataAccess.Select();

            DataTable dt = logisticDataAccess.Select();
            dgvLogistic.DataSource = dt;

            //Зареждане на категориите в комбо бокса
            cmbEmployee.DataSource = logisticDT;

            //Задаване на display and value member
            cmbEmployee.DisplayMember = "username";
            cmbEmployee.ValueMember = "username";

            //Създаване на колони за таблицата
            transactionTable.Columns.Add("Product Name");
            transactionTable.Columns.Add("Rate");
            transactionTable.Columns.Add("Quantity");
            transactionTable.Columns.Add("Total");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                logistic.Empleyee = cmbEmployee.Text;
                logistic.FirstNameEmployee = txtFirstName.Text;
                logistic.LastNameEmployee = txtLastName.Text;
                logistic.Contact = txtContact.Text;
                logistic.Address = txtAddress.Text;
                logistic.Date = txtDate.Text;
                logistic.Description = description;
                logistic.Price = decimal.Parse(txtTotal.Text);
                logistic.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            //Вземане на името и id на влезналия потребител
            string loggedUsr = formLogin.loggedIn;
            userBusinessLogic user = userDataAccess.GetIDFromUsername(loggedUsr);

            logistic.AddedBy = user.Id;

            bool success = logisticDataAccess.Insert(logistic);

            if (success == true)
            {
                MessageBox.Show("Logistic Added Successfully.");

                Clear();

                DataTable dt = logisticDataAccess.Select();
                dgvLogistic.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to Add New Logistic.");
            }

            //Изтриване на всички редове 
            dgvAddedProducts.DataSource = null;
            dgvAddedProducts.Rows.Clear();
        }

        public void Clear()
        {
            txtID.Text = "";
            cmbEmployee.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtDate.Text = "";
            txtTotal.Text = "";
            txtDescription.Text = "";
        }

        private void dgvLogistic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Променлива за запазване на номера на селектирания ред
            int rowIndex = e.RowIndex;

            txtID.Text = dgvLogistic.Rows[rowIndex].Cells[0].Value.ToString();
            cmbEmployee.Text = dgvLogistic.Rows[rowIndex].Cells[1].Value.ToString();
            txtFirstName.Text = dgvLogistic.Rows[rowIndex].Cells[2].Value.ToString();
            txtLastName.Text = dgvLogistic.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvLogistic.Rows[rowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvLogistic.Rows[rowIndex].Cells[5].Value.ToString();
            txtDate.Text = dgvLogistic.Rows[rowIndex].Cells[6].Value.ToString();
            txtDescription.Text = dgvLogistic.Rows[rowIndex].Cells[7].Value.ToString();
            txtTotal.Text = dgvLogistic.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            logistic.Id = int.Parse(txtID.Text);

            try
            {
                logistic.Empleyee = cmbEmployee.Text;
                logistic.FirstNameEmployee = txtFirstName.Text;
                logistic.LastNameEmployee = txtLastName.Text;
                logistic.Contact = txtContact.Text;
                logistic.Address = txtAddress.Text;
                logistic.Date = txtDate.Text;
                logistic.Description = txtDescription.Text;
                logistic.Price = decimal.Parse(txtTotal.Text);
                logistic.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            string loggedUsr = formLogin.loggedIn;
            userBusinessLogic user = userDataAccess.GetIDFromUsername(loggedUsr);

            logistic.AddedBy = user.Id;

            bool success = logisticDataAccess.Update(logistic);

            if (success == true)
            {
                MessageBox.Show("Logistic Successfully Updated.");

                Clear();

                DataTable dt = logisticDataAccess.Select();
                dgvLogistic.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Logistic.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            logistic.Id = int.Parse(txtID.Text);

            bool success = logisticDataAccess.Delete(logistic);

            if (success == true)
            {
                MessageBox.Show("Logistic successfully deleted.");

                Clear();

                DataTable dt = logisticDataAccess.Select();
                dgvLogistic.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Logistic.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                //Визуализация на търсения продукт
                DataTable dt = logisticDataAccess.Search(keywords);
                dgvLogistic.DataSource = dt;
            }
            else
            {
                //Визуализация на всички продукти
                DataTable dt = logisticDataAccess.Select();
                dgvLogistic.DataSource = dt;
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = cmbEmployee.Text;

            if (keyword == "")
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                return;
            }

            userBusinessLogic user = userDataAccess.SearchUserForLogistic(keyword);

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchProduct.Text;

            if (keyword == "")
            {
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
                return;
            }

            productsBusinessLogic product = productDataAccess.GetProductsForTransaction(keyword);

            txtProductName.Text = product.Name;
            txtInventory.Text = product.Quantity.ToString();
            txtRate.Text = product.Rate.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal price = decimal.Parse(txtRate.Text);
            decimal qty;

            try
            {
                qty = decimal.Parse(txtQty.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Select quantity!");
                return;
            }

            decimal total = price * qty;

            decimal result = decimal.Parse(txtTotal.Text);
            result = result + total + 8;
            //Добавяме 8 за доставка

            //Проверка дали има избран продукт 
            if (productName == "")
            {
                MessageBox.Show("Select the product first. Try Again.");
            }
            else
            {
                description = description + txtProductName.Text + "-" + txtQty.Text + "";
                //Добавяне на продукта в таблицата
                transactionTable.Rows.Add(productName, price, qty, total);

                dgvAddedProducts.DataSource = transactionTable;

                txtTotal.Text = result.ToString();
                txtDescription.Text = description;

                //Clear the Textboxes
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
            }

        }
    }
}
