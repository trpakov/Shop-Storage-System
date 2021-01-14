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
    public partial class formArchiveDeliveries : Form
    {
        public formArchiveDeliveries()
        {
            InitializeComponent();
        }

        ArchiveLogisticData archive = new ArchiveLogisticData();

        private void formArchiveDeliveries_Load(object sender, EventArgs e)
        {

            DataTable dt = archive.DisplayAllLogistics();
            dgvDeliveries.DataSource = dt;

            dgvDeliveries.Columns[0].HeaderText = "Logistic ID";
            dgvDeliveries.Columns[1].HeaderText = "Employee";
            dgvDeliveries.Columns[2].HeaderText = "Employee Name";
            dgvDeliveries.Columns[3].HeaderText = "Employee Last Name";
            dgvDeliveries.Columns[4].HeaderText = "Address";
            dgvDeliveries.Columns[5].HeaderText = "Contact";
            dgvDeliveries.Columns[6].HeaderText = "Date";
            dgvDeliveries.Columns[7].HeaderText = "Description";
            dgvDeliveries.Columns[8].HeaderText = "Total Price";
            dgvDeliveries.Columns[9].HeaderText = "Added Date";
            dgvDeliveries.Columns[10].HeaderText = "Added By ID";
            dgvDeliveries.Columns[11].HeaderText = "Added By Name";

            cmbDate.DataSource = dt;
            cmbDate.DisplayMember = "date";
            cmbDate.ValueMember = "date";

        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string date = cmbDate.Text;

            DataTable dt = archive.DisplayLogisticnByDate(date);
            dgvDeliveries.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = archive.DisplayAllLogistics();
            dgvDeliveries.DataSource = dt;
        }
    }
}
