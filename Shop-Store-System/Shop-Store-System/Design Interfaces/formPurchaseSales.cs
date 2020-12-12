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
        productsDataAccess productDataAccess = new productsDataAccess();

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

            //Търсене на продукт в базата данни
            productsBusinessLogic product = productDataAccess.GetProductsForTransaction(keyword);

            //Визуализация на намерените данни в текстовите кутии
            txtProductName.Text = product.Name;
            txtInventory.Text = product.Quantity.ToString();
            txtRate.Text = product.Rate.ToString();
        }
    }
}
