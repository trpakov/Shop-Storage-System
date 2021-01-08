using Shop_Store_System.BusinesLogic;
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
    public partial class formPersonalLogistic : Form
    {
        public formPersonalLogistic()
        {
            InitializeComponent();
        }

        logisticDataAccess logisticDataAccess = new logisticDataAccess();
        userDataAccess userDataAccess = new userDataAccess();
        personalLogisticDataAccess personal = new personalLogisticDataAccess();

        private void formPersonalLogistic_Load(object sender, EventArgs e)
        {
            string loggedUsr = formLogin.loggedIn;

            DataTable logisticDT = personal.DisplayLogisticByUsername(loggedUsr);

            cmbDate.DataSource = logisticDT;

            cmbDate.DisplayMember = "date";
            cmbDate.ValueMember = "date";
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loggedUsr = formLogin.loggedIn;
            string date = cmbDate.Text;

            DataTable dt = personal.DisplayLogisticnByDate(date, loggedUsr);
            dgvLogistic.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            string loggedUsr = formLogin.loggedIn;

            DataTable dt = personal.DisplayLogisticByUsername(loggedUsr);
            dgvLogistic.DataSource = dt;
        }
    }
}
