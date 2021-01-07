using DGVPrinterHelper;
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
using System.Transactions;
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
        userDataAccess userDataAccess = new userDataAccess();
        transactionDataAccess transactionDataAccess = new transactionDataAccess();
        transactionDetailDataAccess transactionDetailData = new transactionDetailDataAccess();

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

            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + total;

            //Проверка дали има избран продукт 
            if (productName == "")
            {
                MessageBox.Show("Select the product first. Try Again.");
            }
            else
            {
                //Добавяне на продукта в таблицата
                transactionTable.Rows.Add(productName, price, qty, total);

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
                decimal discount;

                try
                {
                    discount = decimal.Parse(txtDiscount.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please add discount!");
                    return;
                }

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
                decimal tax;

                try
                {
                    tax = decimal.Parse(txtVat.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please add tax!");
                    return;
                }

                decimal grandTotal = ((100 + tax) / 100) * previousGT;

                grandTotal = Math.Round(grandTotal, 2);

                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount;

            try
            {
                paidAmount = decimal.Parse(txtPaidAmount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please add paid amount!");
                return;
            }

            decimal returnAmount = paidAmount - grandTotal;

            returnAmount = Math.Round(returnAmount, 2);

            txtReturnAmount.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Вземане на въпросната форма purchase/sales
            transactionBusinessLogic transaction = new transactionBusinessLogic();
            transaction.Type = labelTop.Text;

            //Вземане на името и id-то на доставчика или купувача
            string deaCustName = txtName.Text;
            dealerandcustomerBusinessLogic dealerCustomer = dcDataAccess.GetDeaCustIDFromName(deaCustName);

            transaction.DealerCustomerId = dealerCustomer.Id;
            transaction.GrandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
            transaction.TransactionDate = DateTime.Now;
            transaction.Tax = decimal.Parse(txtVat.Text);
            transaction.Discount = decimal.Parse(txtDiscount.Text);

            //Вземане на потребителското име на потребителя
            string username = formLogin.loggedIn;
            userBusinessLogic user = userDataAccess.GetIDFromUsername(username);

            transaction.AddedBy = user.Id;
            transaction.TransactionDetails = transactionTable;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                //Задаване на стойноста на транзакцията първоначално на -1
                int transactionID = -1;

                //Добавяне на транзакция
                bool insertTransaction = transactionDataAccess.InsertTransaction(transaction, out transactionID);

                //Use for loop to insert Transaction Details
                for (int i = 0; i < transactionTable.Rows.Count; i++)
                {
                    //Вземане на всички детайли за продукта
                    transactionDetailBusinessLogic transactionDetail = new transactionDetailBusinessLogic();

                    //Вземане на id чрез името на продукта
                    string productName = transactionTable.Rows[i][0].ToString();
                    productsBusinessLogic product = productDataAccess.GetProductIDFromName(productName);

                    transactionDetail.ProductId = product.Id;
                    transactionDetail.Rate = decimal.Parse(transactionTable.Rows[i][1].ToString());
                    transactionDetail.Quantity = decimal.Parse(transactionTable.Rows[i][2].ToString());
                    transactionDetail.Total = Math.Round(decimal.Parse(transactionTable.Rows[i][3].ToString()), 2);
                    transactionDetail.DealerCustomerId = dealerCustomer.Id;
                    transactionDetail.AddedDate = DateTime.Now;
                    transactionDetail.AddedBy = user.Id;

                    //Вземане на типа purchase/sales за намаляне или увеличаване на количеството на продуктите 
                    string transactionType = labelTop.Text;

                    bool changeQuantity = false;

                    if (transactionType == "Purchase")
                    {
                        //Увеличаване на количеството на продуктите
                        changeQuantity = productDataAccess.IncreaseProduct(transactionDetail.ProductId, transactionDetail.Quantity);
                    }
                    else if (transactionType == "Sales")
                    {
                        //Намаляне на количеството на продуктите
                        changeQuantity = productDataAccess.DecreaseProduct(transactionDetail.ProductId, transactionDetail.Quantity);
                    }

                    //Добавяне на транзакцията с детайлите около продукта в базата данни
                    bool insertDetails = transactionDetailData.InsertTransactionDetail(transactionDetail);

                    success = insertTransaction && insertDetails && changeQuantity;
                }

                //Проверка дали всичко е успешно
                if (success == true)
                {
                    //Успешно завършено
                    scope.Complete();

                    //Принтиране на сметката
                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n\r\n Store Shop System \r\n\r\n";
                    printer.SubTitle = "12 Group \r\n Phone: 0120012012 \r\n\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount: " + txtDiscount.Text + "% \r\n" + "TAX: " + txtVat.Text + "% \r\n" + "Total: " + txtGrandTotal.Text + "\r\n\r\n" + "Thank you for doing business with us.";
                    printer.FooterSpacing = 10;
                    printer.PrintDataGridView(dgvAddedProducts);

                    MessageBox.Show("Transaction Completed Sucessfully.");

                    //Изтриване на всички редове 
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();
                    //Изтриване на текстовите полета
                    ClearAll();
                   
                }
                else
                {
                    MessageBox.Show("Transaction Failed.");
                }
            }
        }

        public void ClearAll()
        {
            txtSearch.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearchProduct.Text = "";
            txtProductName.Text = "";
            txtInventory.Text = "0";
            txtRate.Text = "0";
            txtQty.Text = "0";
            txtSubTotal.Text = "0";
            txtDiscount.Text = "0";
            txtVat.Text = "0";
            txtGrandTotal.Text = "0";
            txtPaidAmount.Text = "0";
            txtReturnAmount.Text = "0";
        }
    }
}
