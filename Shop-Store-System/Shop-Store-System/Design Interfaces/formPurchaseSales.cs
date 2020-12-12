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
    public partial class formPurchaseSales : Form
    {
        public formPurchaseSales()
        {
            InitializeComponent();
        }

        dealerandcustomerDataAccess dcDataAccess = new dealerandcustomerDataAccess();

        private void formPurchaseSales_Load(object sender, EventArgs e)
        {
            string type = formUserDashboard.transactionType;
            labelTop.Text = type;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword == "")
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            //Търсене в данните и връщане в обект от dealer and customer business logic 
            dealerandcustomerBusinessLogic dc = dcDataAccess.SearchDealerCustomerForTransaction(keyword);

            //Визуализация на намерените данни в текстовите кутии
            txtName.Text = dc.Name;
            txtEmail.Text = dc.Email;
            txtContact.Text = dc.Contact;
            txtAddress.Text = dc.Address;
        }
    }
}
