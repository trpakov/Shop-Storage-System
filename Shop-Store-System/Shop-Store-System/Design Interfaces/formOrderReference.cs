using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Store_System.BusinesLogic;
using Shop_Store_System.BusinessLogic;
using Shop_Store_System.DataAccess;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace Shop_Store_System.Design_Interfaces
{
    public partial class formOrderReference : Form
    {
        DataTable mainDT;
        DataView dv;

        TransactionData transactionData = new TransactionData();
        DealerCustomerData dcd = new DealerCustomerData();

        int numOfPurchases = 0;
        int numOfSales = 0;
        int numOfOrders0to50 = 0;
        int numOfOrders50to200 = 0;
        int numOfOrders200to500 = 0;
        int numOfOrders500to1000 = 0;
        int numOfOrdersMoreThan1000 = 0;

        public formOrderReference()
        {
            InitializeComponent();
        }

        private void formOrderReference_Load(object sender, EventArgs e)
        {
            TopMost = true;
            WindowState = FormWindowState.Maximized;

            radioButtonAll.Checked = true;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;

            cmbTransactionType.Items.Add("All");
            comboBoxAddedBy.Items.Add("All");
            comboBoxDealCust.Items.Add("All");
            cmbTransactionType.SelectedItem = comboBoxAddedBy.SelectedItem = comboBoxDealCust.SelectedItem = "All";
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                //dateTimePicker2.Enabled = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!radioButtonAll.Checked)
            {
                //var date1 = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
                //var date2 = dateTimePicker2.Value.Year + "/" + dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.AddDays(1).Day;

                mainDT = transactionData.GeTransactionsInRange(dateTimePicker1.Value, dateTimePicker2.Value);
            }
            else
            {
                mainDT = transactionData.DisplayAllTransactions();
            }

            cmbTransactionType.Enabled = true;
            comboBoxAddedBy.Enabled = true;
            comboBoxDealCust.Enabled = true;

            foreach (DataRow row in mainDT.Rows)
            {
                if (!cmbTransactionType.Items.Contains(row["type"]))
                    cmbTransactionType.Items.Add(row["type"]);

                if (!comboBoxAddedBy.Items.Contains(row["added_by_name"]))
                    comboBoxAddedBy.Items.Add(row["added_by_name"]);

                var dealCust = dcd.GetDeaCustNameFromID(int.Parse(row["dea_cust_id"].ToString()));
                var dealCustName = dealCust.Name ?? "Not Specified";
                if (!comboBoxDealCust.Items.Contains(dealCustName))
                    comboBoxDealCust.Items.Add(dealCustName);
            }

            cmbTransactionType.SelectedItem = comboBoxAddedBy.SelectedItem = comboBoxDealCust.SelectedItem = "All";

            dv = new DataView(mainDT);
            dgvOrders.DataSource = dv;
            RenameGrid();
            CalculateTotals();
        }

        private void FilterData(object sender, EventArgs e)
        {
            var typeFilter = "type LIKE " + (cmbTransactionType.SelectedItem.ToString() == "All" ? "'%'" : $"'{cmbTransactionType.SelectedItem.ToString()}'");
            var userFilter = " AND added_by_name LIKE " + (comboBoxAddedBy.SelectedItem.ToString() == "All" ? "'%'" : $"'{comboBoxAddedBy.SelectedItem.ToString()}'");
            var dealCustFilter = comboBoxDealCust.SelectedItem.ToString() == "All" ? string.Empty : $" AND dea_cust_id = {dcd.GetDeaCustIDFromName(comboBoxDealCust.SelectedItem.ToString()).Id}";

            var filter = typeFilter + userFilter + dealCustFilter;
            dv.RowFilter = filter;
            CalculateTotals();
        }

        private void RenameGrid()
        {
            dgvOrders.Columns[0].HeaderText = "Transaction ID";
            dgvOrders.Columns[1].HeaderText = "Type";
            dgvOrders.Columns[2].HeaderText = "Dealer Customer Id";
            dgvOrders.Columns[3].HeaderText = "Description";
            dgvOrders.Columns[4].HeaderText = "Total";
            dgvOrders.Columns[5].HeaderText = "Date";
            dgvOrders.Columns[6].HeaderText = "Tax";
            dgvOrders.Columns[7].HeaderText = "Discount";
            dgvOrders.Columns[8].HeaderText = "Paid Amount";
            dgvOrders.Columns[9].HeaderText = "Return Amount";
            dgvOrders.Columns[10].HeaderText = "Added By ID";
            dgvOrders.Columns[11].HeaderText = "Added By Name";
        }

        private void CalculateTotals()
        {
            double price = 0;
            double avgPrice = 0;
            double tax = 0;
            double disco = 0;
            int items = 0;
            numOfPurchases = 0;
            numOfSales = 0;
            numOfOrders0to50 = 0;
            numOfOrders50to200 = 0;
            numOfOrders200to500 = 0;
            numOfOrders500to1000 = 0;
            numOfOrdersMoreThan1000 = 0;

            foreach (DataRowView rowView in dv)
            {
                var currentItemPrice = double.Parse(rowView.Row["grandTotal"].ToString());
                price += currentItemPrice;
                tax += double.Parse(rowView.Row["tax"].ToString());
                disco += double.Parse(rowView.Row["discount"].ToString());

                var numOfItems = Regex.Matches(rowView.Row["description"].ToString(), @"(?<==)\d+");
                foreach (Match match in numOfItems)
                    items += int.Parse(match.Value);

                if (rowView.Row["type"].ToString() == "Purchase") numOfPurchases++; else numOfSales++;

                if (currentItemPrice <= 50) numOfOrders0to50++;
                else if (currentItemPrice > 50 && currentItemPrice <= 200) numOfOrders50to200++;
                else if (currentItemPrice > 200 && currentItemPrice <= 500) numOfOrders200to500++;
                else if (currentItemPrice > 500 && currentItemPrice <= 1000) numOfOrders500to1000++;
                else if (currentItemPrice > 1000) numOfOrdersMoreThan1000++;
            }

            avgPrice = Math.Round(price / dv.Count, 2);
            tax = Math.Round(tax / dv.Count, 2) / 100;
            disco = Math.Round(disco / dv.Count, 2) / 100;

            textBoxPrice.Text = price.ToString("c");
            textBoxAvgPrice.Text = avgPrice.ToString("c");
            textBoxAvgTax.Text = tax.ToString("p");
            textBoxDisco.Text = disco.ToString("p");
            textBoxItems.Text = items.ToString();

            DrawTypesChart();
            DrawPriceChart();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void DrawTypesChart()
        {
            chartTypes.Series.Clear();
            chartTypes.Legends.Clear();

            chartTypes.Legends.Add("Type");
            chartTypes.Legends[0].LegendStyle = LegendStyle.Table;
            chartTypes.Legends[0].Docking = Docking.Bottom;
            chartTypes.Legends[0].Alignment = StringAlignment.Center;
            chartTypes.Legends[0].Title = "Type";
            chartTypes.Legends[0].BorderColor = Color.Black;

            chartTypes.Series.Add("Type");
            chartTypes.Series["Type"].ChartType = SeriesChartType.Pie;
            chartTypes.Series["Type"].IsValueShownAsLabel = true;
            chartTypes.Series[0].Font = new Font("Consolas", 20f);

            if(numOfPurchases != 0)
                chartTypes.Series[0].Points.AddXY("Purchase", numOfPurchases);
            if(numOfSales != 0)
                chartTypes.Series[0].Points.AddXY("Sales", numOfSales);
        }

        private void DrawPriceChart()
        {
            chartPrice.Series.Clear();
            chartPrice.Legends.Clear();

            chartPrice.Legends.Add("Price");
            chartPrice.Legends[0].LegendStyle = LegendStyle.Table;
            chartPrice.Legends[0].Docking = Docking.Bottom;
            chartPrice.Legends[0].Alignment = StringAlignment.Center;
            chartPrice.Legends[0].Title = "Number of orders in given prince (BGN) range";
            chartPrice.Legends[0].BorderColor = Color.Black;

            chartPrice.Series.Add("Number of orders");
            chartPrice.Series[0].ChartType = SeriesChartType.Column;
            chartPrice.Series[0].IsValueShownAsLabel = true;
            chartPrice.Series[0].Font = new Font("Consolas", 20f);
            chartPrice.ChartAreas[0].AxisY.Interval = 1;
            chartPrice.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            chartPrice.Series[0].Points.AddXY("0-50", numOfOrders0to50);
            chartPrice.Series[0].Points.AddXY("51-200", numOfOrders50to200);
            chartPrice.Series[0].Points.AddXY("201-500", numOfOrders200to500);
            chartPrice.Series[0].Points.AddXY("501-1000", numOfOrders500to1000);
            chartPrice.Series[0].Points.AddXY("1000+", numOfOrdersMoreThan1000);
        }
    }
}
