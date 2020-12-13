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

        transactionDataAccess transactionDataAccess = new transactionDataAccess();

        private void formTransactions_Load(object sender, EventArgs e)
        {
            DataTable dt = transactionDataAccess.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbTransactionType.Text;

            DataTable dt = transactionDataAccess.DisplayTransactionByType(type);
            dgvTransactions.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = transactionDataAccess.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }
    }
}
