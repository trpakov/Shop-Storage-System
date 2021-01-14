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

        UserData userData = new UserData();
        Logistic logistic = new Logistic();
        LogisticData logisticData = new LogisticData();
        ProductData productData = new ProductData();

        DataTable transactionTable = new DataTable();

        int productId;

        string description = null;
        string specialNumber = null;

        private void formLogistic_Load(object sender, EventArgs e)
        {
            //Създаване на таблица за взимане на данните от категориите
            DataTable logisticDT = userData.Select();

            DataTable dt = logisticData.Select();
            dgvLogistic.DataSource = dt;
            dgvLogistic.Columns[0].HeaderText = "Logistic ID";
            dgvLogistic.Columns[1].HeaderText = "Employee";
            dgvLogistic.Columns[2].HeaderText = "Employee Name";
            dgvLogistic.Columns[3].HeaderText = "Employee Last Name";
            dgvLogistic.Columns[4].HeaderText = "Address";
            dgvLogistic.Columns[5].HeaderText = "Contact";
            dgvLogistic.Columns[6].HeaderText = "Date";
            dgvLogistic.Columns[7].HeaderText = "Description";
            dgvLogistic.Columns[8].HeaderText = "Total Price";
            dgvLogistic.Columns[9].HeaderText = "Added Date";
            dgvLogistic.Columns[10].HeaderText = "Added By ID";
            dgvLogistic.Columns[11].HeaderText = "Added By Name";

            //Зареждане на категориите в комбо бокса
            cmbEmployee.DataSource = logisticDT;

            //Задаване на display and value member
            cmbEmployee.DisplayMember = "username";
            cmbEmployee.ValueMember = "username";

            //Създаване на колони за таблицата
            transactionTable.Columns.Add("Special Number");
            transactionTable.Columns.Add("Product Name");
            transactionTable.Columns.Add("Rate");
            transactionTable.Columns.Add("Quantity");
            transactionTable.Columns.Add("Total");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                logistic.Contact = txtContact.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid contact! Try again.");
                return;
            }
            try
            {
                logistic.Empleyee = cmbEmployee.Text;
                logistic.FirstNameEmployee = txtFirstName.Text;
                logistic.LastNameEmployee = txtLastName.Text;
                logistic.Address = txtAddress.Text;
                logistic.Date = txtDate.Text;
                logistic.Description = description;
                logistic.Price = decimal.Parse(txtTotal.Text);
                logistic.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input! Try again.");
                return;
            }

            //Вземане на името и id на влезналия потребител
            string loggedUsr = formLogin.loggedIn;
            User user = userData.GetIDFromUsername(loggedUsr);

            logistic.AddedBy = user.Id;
            logistic.AddedByName = loggedUsr;

            bool success = logisticData.Insert(logistic);

            if (success == true)
            {
                MessageBox.Show("Logistic Added Successfully.");



                Clear();

                DataTable dt = logisticData.Select();
                dgvLogistic.DataSource = dt;

                transactionTable.Clear();
                description = null;

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
            txtTotal.Text = "0";
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
                logistic.Contact = txtContact.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid contact! Try again.");
                return;
            }

            try
            {
                logistic.Empleyee = cmbEmployee.Text;
                logistic.FirstNameEmployee = txtFirstName.Text;
                logistic.LastNameEmployee = txtLastName.Text;
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
            User user = userData.GetIDFromUsername(loggedUsr);

            logistic.AddedBy = user.Id;
            logistic.AddedByName = loggedUsr;

            bool success = logisticData.Update(logistic);

            if (success == true)
            {
                MessageBox.Show("Logistic Successfully Updated.");

                Clear();

                DataTable dt = logisticData.Select();
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

            //Връщане на количестото
            string info = txtDescription.Text;

            string[] arr = info.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                string pair = arr[i];

                string[] arr2 = pair.Split('=').ToArray();

                string productName = arr2[0];
                int qty = int.Parse(arr2[1]);

                Product product = productData.GetProductIDFromName(productName);

                bool changeQuantity = productData.IncreaseProduct(product.Id, qty);
            }


            bool success = logisticData.Delete(logistic);

            if (success == true)
            {
                MessageBox.Show("Logistic successfully deleted.");


                Clear();

                DataTable dt = logisticData.Select();
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
                DataTable dt = logisticData.Search(keywords);
                dgvLogistic.DataSource = dt;
            }
            else
            {
                //Визуализация на всички продукти
                DataTable dt = logisticData.Select();
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

            User user = userData.SearchUserForLogistic(keyword);

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

            Product product = logisticData.GetProductsForLogistic(keyword);

            productId = product.Id;

            specialNumber = product.SpecialNumber;

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
                MessageBox.Show("Select quantity first!");
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
                description = description + txtProductName.Text + "=" + txtQty.Text + " ";

                //Добавяне на продукта в таблицата
                transactionTable.Rows.Add(specialNumber, productName, price, qty, total);

                dgvAddedProducts.DataSource = transactionTable;

                txtTotal.Text = result.ToString();
                txtDescription.Text = description;

                bool changeQuantity = productData.DecreaseProduct(productId, qty);

                if (changeQuantity)
                {
                    specialNumber = null;
                    MessageBox.Show("Added Sucesfully!");
                }
                else
                {
                    specialNumber = null;
                    MessageBox.Show("No products in inventory!");
                    return;
                }


                //Clear the Textboxes
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            cmbEmployee.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtDate.Text = "";
            txtSearch.Text = "";
            txtSearchProduct.Text = "";
            txtProductName.Text = "";
            txtInventory.Text = "";
            txtRate.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "0";
            txtDescription.Text = "";
        }
    }
}
