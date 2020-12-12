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

        DataTable transactionTable = new DataTable();

        private void formPurchaseSales_Load(object sender, EventArgs e)
        {
            string type = formUserDashboard.transactionType;
            labelTop.Text = type;

            //Създаване на колони за таблицата
            transactionTable.Columns.Add("Product Name");
            transactionTable.Columns.Add("Rate");
            transactionTable.Columns.Add("Quantity");
            transactionTable.Columns.Add("Total");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQty.Text);

            decimal Total = Rate * Qty;

            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + Total;

            //Проверка дали има избран продукт 
            if (productName == "")
            {
                MessageBox.Show("Select the product first. Try Again.");
            }
            else
            {
                //Добавяне на продукта в таблицата
                transactionTable.Rows.Add(productName, Rate, Qty, Total);

                dgvAddedProducts.DataSource = transactionTable;

                txtSubTotal.Text = subTotal.ToString();

                //Clear the Textboxes
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "0.00";
                txtRate.Text = "0.00";
                txtQty.Text = "0.00";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtDiscount.Text;

            if (value == "")
            {
                MessageBox.Show("Please Add Discount First.");
            }
            else
            {
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);

                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                grandTotal = Math.Round(grandTotal, 2);

                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            string check = txtGrandTotal.Text;

            if (check == "")
            {
                MessageBox.Show("Calculate the discount and set the Grand Total First.");
            }
            else
            {
                decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                decimal tax = decimal.Parse(txtVat.Text);
                decimal grandTotal = ((100 + tax) / 100) * previousGT;

                grandTotal = Math.Round(grandTotal, 2);

                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            returnAmount = Math.Round(returnAmount, 2);

            txtReturnAmount.Text = returnAmount.ToString();
        }
    }
}
