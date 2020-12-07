using Shop_Store_System.BusinesLogic;
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
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }

        userBusinessLogic user = new userBusinessLogic();
        userDataAccess userDataAccess = new userDataAccess();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Взимане на данни от текстовите кутии
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Contact = txtContact.Text;
            user.Address = txtAddress.Text;
            user.Gender = cmbGender.Text;
            user.UserType = cmbUserType.Text;
            user.AddedDate = DateTime.Now;

            //Вземане на името на влезналия потребител
            string loggedUser = formLogin.loggedIn;
            userBusinessLogic usr = userDataAccess.GetIDFromUsername(loggedUser);

            user.AddedBy = usr.Id;


            //Вкарване на данни в базата данни
            bool success = userDataAccess.Insert(user);
            
            if (success == true)
            {
                MessageBox.Show("User successfully created.");
                Clear();
            }
            else
            {
                
                MessageBox.Show("Failed to add new user.");
            }

            //Обновяване на таблицата във формата за потребители
            DataTable dt = userDataAccess.Select();
            dgvUsers.DataSource = dt;
        }

        private void formUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = userDataAccess.Select();
            dgvUsers.DataSource = dt;
        }

        private void Clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Вземане на индекса за реда
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Вземане на данните от текстовите кутии
            user.Id = int.Parse(txtUserID.Text);
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Contact = txtContact.Text;
            user.Address = txtAddress.Text;
            user.Gender = cmbGender.Text;
            user.UserType = cmbUserType.Text;
            user.AddedDate = DateTime.Now;

            //user.AddedBy = 1;

            //---------------------------------------------------------------------------------------
            string loggedUser = formLogin.loggedIn;
            userBusinessLogic usr = userDataAccess.GetIDFromUsername(loggedUser);

            user.AddedBy = usr.Id;
            //---------------------------------------------------------------------------------------

            //Редактиране на данните в базата данни
            bool success = userDataAccess.Update(user);

            
            if (success == true)
            {
                MessageBox.Show("User successfully updated.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update user.");
            }

            DataTable dt = userDataAccess.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Вземане на id-то за потребителя от формата
            user.Id = int.Parse(txtUserID.Text);

            bool success = userDataAccess.Delete(user);

            if (success == true)
            {
                MessageBox.Show("User deleted successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete user");

            }

            DataTable dt = userDataAccess.Select();
            dgvUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Вземане на думата от текстовата кутия
            string keywords = txtSearch.Text;

            //Проверка дали има стойност
            if (keywords != null)
            {
                //Показване на потребителя
                DataTable dt = userDataAccess.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //Показване на всички потребители
                DataTable dt = userDataAccess.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void formUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
        }
    }
}
