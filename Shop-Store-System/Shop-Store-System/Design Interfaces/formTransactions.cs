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
    public partial class formTransactions : Form
    {
        public formTransactions()
        {
            InitializeComponent();
        }

        TransactionData transactionData = new TransactionData();

        private void formTransactions_Load(object sender, EventArgs e)
        {
            DataTable dt = transactionData.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
            dgvTransactions.Columns[0].HeaderText = "Transaction ID";
            dgvTransactions.Columns[1].HeaderText = "Type";
            dgvTransactions.Columns[2].HeaderText = "Dealer Customer Id";
            dgvTransactions.Columns[3].HeaderText = "Description";
            dgvTransactions.Columns[4].HeaderText = "Total";
            dgvTransactions.Columns[5].HeaderText = "Date";
            dgvTransactions.Columns[6].HeaderText = "Tax";
            dgvTransactions.Columns[7].HeaderText = "Discount";
            dgvTransactions.Columns[8].HeaderText = "Paid Amount";
            dgvTransactions.Columns[9].HeaderText = "Return Amount";
            dgvTransactions.Columns[10].HeaderText = "Added By ID";

        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbTransactionType.Text;

            DataTable dt = transactionData.DisplayTransactionByType(type);
            dgvTransactions.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = transactionData.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataTable dt = transactionData.DeleteAllTransactions();
            dgvTransactions.DataSource = dt;
        }
    }
}
