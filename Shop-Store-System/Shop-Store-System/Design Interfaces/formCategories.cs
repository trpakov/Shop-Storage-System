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
    public partial class formCategories : Form
    {
        public formCategories()
        {
            InitializeComponent();
        }

        Category category = new Category();
        CategoryData categoryData = new CategoryData();
        UserData userData = new UserData();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Вземане на данните от тектовите кутии
            category.Title = txtTitle.Text;
            category.Description = txtDescription.Text;
            category.AddedDate = DateTime.Now;

            //Вземане на Idна влезналия потребител
            string loggedUser = formLogin.loggedIn;
            User user = userData.GetIDFromUsername(loggedUser);

            category.AddedBy = user.Id;

            //Вкарване на данните в базата данни
            bool success = categoryData.Insert(category);

            if (success == true)
            {
                MessageBox.Show("New Category Inserted Successfully.");
                Clear();

                DataTable dt = categoryData.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Insert New CAtegory.");
            }
        }

        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void formCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = categoryData.Select();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Вземане на реда
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            category.Id = int.Parse(txtCategoryID.Text);
            category.Title = txtTitle.Text;
            category.Description = txtDescription.Text;
            category.AddedDate = DateTime.Now;

            string loggedUser = formLogin.loggedIn;
            User user = userData.GetIDFromUsername(loggedUser);

            category.AddedBy = user.Id;

            bool success = categoryData.Update(category);

            if (success == true)
            {
                MessageBox.Show("Category Updated Successfully.");
                Clear();

                DataTable dt = categoryData.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Category.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            category.Id = int.Parse(txtCategoryID.Text);

            bool success = categoryData.Delete(category);

            if (success == true)
            {
                MessageBox.Show("Category Deleted Successfully.");
                Clear();

                DataTable dt = categoryData.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Category.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = categoryData.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                DataTable dt = categoryData.Select();
                dgvCategories.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
