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

        private void formLogistic_Load(object sender, EventArgs e)
        {
            //Създаване на таблица за взимане на данните от категориите
            DataTable logisticDT = userDataAccess.Select();

            //Зареждане на категориите в комбо бокса
            cmbEmployee.DataSource = logisticDT;

            //Задаване на display and value member
            cmbEmployee.DisplayMember = "username";
            cmbEmployee.ValueMember = "username";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                logistic.Empleyee = cmbEmployee.Text;
                logistic.Contact = txtContact.Text;
                logistic.Address = txtAddress.Text;
                logistic.Date = txtDate.Text;
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
                MessageBox.Show("Failed to Add New Product.");
            }
        }

        public void Clear()
        {
            txtID.Text = "";
            cmbEmployee.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtDate.Text = "";
        }

        private void dgvLogistic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Променлива за запазване на номера на селектирания ред
            int rowIndex = e.RowIndex;

            txtID.Text = dgvLogistic.Rows[rowIndex].Cells[0].Value.ToString();
            cmbEmployee.Text = dgvLogistic.Rows[rowIndex].Cells[1].Value.ToString();
            txtAddress.Text = dgvLogistic.Rows[rowIndex].Cells[2].Value.ToString();
            txtContact.Text = dgvLogistic.Rows[rowIndex].Cells[3].Value.ToString();
            txtDate.Text = dgvLogistic.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            logistic.Id = int.Parse(txtID.Text);

            try
            {
                logistic.Empleyee = cmbEmployee.Text;
                logistic.Contact = txtContact.Text;
                logistic.Address = txtAddress.Text;
                logistic.Date = txtDate.Text;
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
    }
}
