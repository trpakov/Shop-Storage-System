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
    public partial class formDelivery : Form
    {
        public formDelivery()
        {
            InitializeComponent();
        }

        LogisticData logisticData = new LogisticData();
        UserData userData = new UserData();
        PersonalLogisticData personalData = new PersonalLogisticData();
        Logistic logistic = new Logistic();

        ArchiveLogisticData archive = new ArchiveLogisticData();

        private void formPersonalLogistic_Load(object sender, EventArgs e)
        {
            string loggedUsr = formLogin.loggedIn;

            DataTable logisticDT = personalData.DisplayLogisticByUsername(loggedUsr);
            
            cmbDate.DataSource = logisticDT;

            cmbDate.DisplayMember = "date";
            cmbDate.ValueMember = "date";
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loggedUsr = formLogin.loggedIn;
            string date = cmbDate.Text;

            DataTable dt = personalData.DisplayLogisticnByDate(date, loggedUsr);
            dgvLogistic.DataSource = dt;
            dgvLogistic.Columns[0].HeaderText = "Logistic ID";
            dgvLogistic.Columns[1].HeaderText = "Employee";
            dgvLogistic.Columns[2].HeaderText = "Employee Name";
            dgvLogistic.Columns[3].HeaderText = "Employee Last Name";
            dgvLogistic.Columns[4].HeaderText = "Address";
            dgvLogistic.Columns[5].HeaderText = "Contact";
            dgvLogistic.Columns[6].HeaderText = "Date";
            dgvLogistic.Columns[7].HeaderText = "Description";
            dgvLogistic.Columns[8].HeaderText = "Total Price";
            dgvLogistic.Columns[9].HeaderText = "Added Date";
            dgvLogistic.Columns[10].HeaderText = "Added By ID";
            dgvLogistic.Columns[11].HeaderText = "Added By Name";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            string loggedUsr = formLogin.loggedIn;

            DataTable dt = personalData.DisplayLogisticByUsername(loggedUsr);
            dgvLogistic.DataSource = dt;
            dgvLogistic.Columns[0].HeaderText = "Logistic ID";
            dgvLogistic.Columns[1].HeaderText = "Employee";
            dgvLogistic.Columns[2].HeaderText = "Employee Name";
            dgvLogistic.Columns[3].HeaderText = "Employee Last Name";
            dgvLogistic.Columns[4].HeaderText = "Address";
            dgvLogistic.Columns[5].HeaderText = "Contact";
            dgvLogistic.Columns[6].HeaderText = "Date";
            dgvLogistic.Columns[7].HeaderText = "Description";
            dgvLogistic.Columns[8].HeaderText = "Total Price";
            dgvLogistic.Columns[9].HeaderText = "Added Date";
            dgvLogistic.Columns[10].HeaderText = "Added By ID";
            dgvLogistic.Columns[11].HeaderText = "Added By Name";
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            string loggedUsr = formLogin.loggedIn;

            bool inserted = archive.Insert(logistic);

            if (inserted)
            {
                MessageBox.Show("Logistic saved.");
            }
            else
            {
                MessageBox.Show("Failed.");
                return;
            }

            bool success = logisticData.Delete(logistic);

            if (success == true)
            {
                MessageBox.Show("Logistic successfully delevered.");

                DataTable dt = personalData.DisplayLogisticByUsername(loggedUsr);
                dgvLogistic.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void dgvLogistic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            logistic.Id = int.Parse(dgvLogistic.Rows[rowIndex].Cells[0].Value.ToString());
            logistic.Empleyee = dgvLogistic.Rows[rowIndex].Cells[1].Value.ToString();
            logistic.FirstNameEmployee = dgvLogistic.Rows[rowIndex].Cells[2].Value.ToString();
            logistic.LastNameEmployee = dgvLogistic.Rows[rowIndex].Cells[3].Value.ToString();
            logistic.Address = dgvLogistic.Rows[rowIndex].Cells[4].Value.ToString();
            logistic.Contact = dgvLogistic.Rows[rowIndex].Cells[5].Value.ToString();
            logistic.Date = dgvLogistic.Rows[rowIndex].Cells[6].Value.ToString();
            logistic.Description = dgvLogistic.Rows[rowIndex].Cells[7].Value.ToString();
            logistic.Price = decimal.Parse(dgvLogistic.Rows[rowIndex].Cells[8].Value.ToString());
            logistic.AddedDate = DateTime.Parse(dgvLogistic.Rows[rowIndex].Cells[9].Value.ToString());
            logistic.AddedBy = int.Parse(dgvLogistic.Rows[rowIndex].Cells[10].Value.ToString());
            logistic.AddedByName = dgvLogistic.Rows[rowIndex].Cells[11].Value.ToString();
        }
    }
}
