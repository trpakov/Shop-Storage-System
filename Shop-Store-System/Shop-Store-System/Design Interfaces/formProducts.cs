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

        categoriesDataAccess categoryDataAccess = new categoriesDataAccess();
        productsBusinessLogic p = new productsBusinessLogic();
        productsDataAccess pdal = new productsDataAccess();
        userDataAccess udal = new userDataAccess();

        private void formProducts_Load(object sender, EventArgs e)
        {
            //Създаване на таблица за взимане на данните от категориите
            DataTable categoriesDT = categoryDataAccess.Select();

            //Зареждане на категориите в комбо бокса
            cmbCategory.DataSource = categoriesDT;

            //Задаване на display and value member
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }
    }
}
