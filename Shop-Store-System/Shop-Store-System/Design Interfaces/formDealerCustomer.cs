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
    public partial class formDealerCustomer : Form
    {
        public formDealerCustomer()
        {
            InitializeComponent();
        }

        dealerandcustomerBusinessLogic dealerCustomer = new dealerandcustomerBusinessLogic();
        dealerandcustomerDataAccess dealerCustomerDataAccess = new dealerandcustomerDataAccess();
        userDataAccess userDataAccess = new userDataAccess();

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                dealerCustomer.Name = txtName.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid name!");
                return;
            }
            try
            {
                dealerCustomer.Email = txtEmail.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid email! Try again.");
                return;
            }
            try
            {
                dealerCustomer.Type = cmbDeaCust.Text;
                dealerCustomer.Contact = txtContact.Text;
                dealerCustomer.Address = txtAddress.Text;
                dealerCustomer.AddedDate = DateTime.Now;
            }
            catch(Exception )
            {
                MessageBox.Show("Invalid input!");
                return;
            }

                    string loggedUsr = formLogin.loggedIn;
            userBusinessLogic user = userDataAccess.GetIDFromUsername(loggedUsr);
            dealerCustomer.AddedBy = user.Id;

            bool success = dealerCustomerDataAccess.Insert(dealerCustomer);

            if (success == true)
            {
                MessageBox.Show("Person Added Successfully.");
                Clear();

                DataTable dt = dealerCustomerDataAccess.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Add Person.");
            }
        }

        public void Clear()
        {
            txtDeaCustID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void formDealerCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = dealerCustomerDataAccess.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Вземане на селектирания ред
            int rowIndex = e.RowIndex;

            txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCust.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dealerCustomer.Id = int.Parse(txtDeaCustID.Text);

            try
            {
                dealerCustomer.Name = txtName.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid name!");
                return;
            }
            try
            {
                dealerCustomer.Email = txtEmail.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid email! Try again.");
                return;
            }
            try
            {
                dealerCustomer.Type = cmbDeaCust.Text;
                dealerCustomer.Contact = txtContact.Text;
                dealerCustomer.Address = txtAddress.Text;
                dealerCustomer.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
                return;
            }


            string loggedUsr = formLogin.loggedIn;
            userBusinessLogic user = userDataAccess.GetIDFromUsername(loggedUsr);
            dealerCustomer.AddedBy = user.Id;

            bool success = dealerCustomerDataAccess.Update(dealerCustomer);

            if (success == true)
            {
                MessageBox.Show("Person Updated Successfully.");

                Clear();
                DataTable dt = dealerCustomerDataAccess.Select();

                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Udpate Person.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dealerCustomer.Id = int.Parse(txtDeaCustID.Text);

            bool success = dealerCustomerDataAccess.Delete(dealerCustomer);

            if (success == true)
            {
                MessageBox.Show("Person Deleted Successfully");

                Clear();

                DataTable dt = dealerCustomerDataAccess.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Person.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword != null)
            {
                DataTable dt = dealerCustomerDataAccess.Search(keyword);
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                DataTable dt = dealerCustomerDataAccess.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
