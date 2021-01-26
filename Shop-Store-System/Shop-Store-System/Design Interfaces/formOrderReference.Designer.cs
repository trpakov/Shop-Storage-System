namespace Shop_Store_System.Design_Interfaces
{
    partial class formOrderReference
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonPeriod = new System.Windows.Forms.RadioButton();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.labelAddedBy = new System.Windows.Forms.Label();
            this.comboBoxAddedBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDealCust = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAvgPrice = new System.Windows.Forms.Label();
            this.labelAvgTax = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAvgPrice = new System.Windows.Forms.TextBox();
            this.chartTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAvgTax = new System.Windows.Forms.TextBox();
            this.labelDisco = new System.Windows.Forms.Label();
            this.textBoxDisco = new System.Windows.Forms.TextBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(2, 2);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1253, 351);
            this.dgvOrders.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.Location = new System.Drawing.Point(433, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker2.Location = new System.Drawing.Point(730, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(987, 15);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 34);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // labelShow
            // 
            this.labelShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(72, 13);
            this.labelShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(82, 37);
            this.labelShow.TabIndex = 5;
            this.labelShow.Text = "View:";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAll.Location = new System.Drawing.Point(171, 22);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(41, 20);
            this.radioButtonAll.TabIndex = 6;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonPeriod
            // 
            this.radioButtonPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonPeriod.AutoSize = true;
            this.radioButtonPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPeriod.Location = new System.Drawing.Point(241, 22);
            this.radioButtonPeriod.Name = "radioButtonPeriod";
            this.radioButtonPeriod.Size = new System.Drawing.Size(117, 20);
            this.radioButtonPeriod.TabIndex = 7;
            this.radioButtonPeriod.TabStop = true;
            this.radioButtonPeriod.Text = "Specific Period";
            this.radioButtonPeriod.UseVisualStyleBackColor = true;
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(384, 22);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(44, 19);
            this.labelFrom.TabIndex = 8;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(697, 22);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(28, 19);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "To:";
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(270, 22);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(42, 19);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Type:";
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.Enabled = false;
            this.cmbTransactionType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(316, 18);
            this.cmbTransactionType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(148, 27);
            this.cmbTransactionType.Sorted = true;
            this.cmbTransactionType.TabIndex = 12;
            this.cmbTransactionType.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // labelAddedBy
            // 
            this.labelAddedBy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAddedBy.AutoSize = true;
            this.labelAddedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddedBy.Location = new System.Drawing.Point(555, 22);
            this.labelAddedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddedBy.Name = "labelAddedBy";
            this.labelAddedBy.Size = new System.Drawing.Size(71, 19);
            this.labelAddedBy.TabIndex = 13;
            this.labelAddedBy.Text = "Added By:";
            // 
            // comboBoxAddedBy
            // 
            this.comboBoxAddedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxAddedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddedBy.Enabled = false;
            this.comboBoxAddedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAddedBy.FormattingEnabled = true;
            this.comboBoxAddedBy.Location = new System.Drawing.Point(630, 18);
            this.comboBoxAddedBy.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAddedBy.Name = "comboBoxAddedBy";
            this.comboBoxAddedBy.Size = new System.Drawing.Size(148, 27);
            this.comboBoxAddedBy.Sorted = true;
            this.comboBoxAddedBy.TabIndex = 14;
            this.comboBoxAddedBy.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dealer/Customer:";
            // 
            // comboBoxDealCust
            // 
            this.comboBoxDealCust.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDealCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDealCust.Enabled = false;
            this.comboBoxDealCust.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDealCust.FormattingEnabled = true;
            this.comboBoxDealCust.Location = new System.Drawing.Point(944, 18);
            this.comboBoxDealCust.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDealCust.Name = "comboBoxDealCust";
            this.comboBoxDealCust.Size = new System.Drawing.Size(148, 27);
            this.comboBoxDealCust.Sorted = true;
            this.comboBoxDealCust.TabIndex = 16;
            this.comboBoxDealCust.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(69, 13);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(86, 37);
            this.labelFilter.TabIndex = 10;
            this.labelFilter.Text = "Filter:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(75, 8);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 37);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Totals:";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(177, 17);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 19);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price:";
            // 
            // labelAvgPrice
            // 
            this.labelAvgPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAvgPrice.AutoSize = true;
            this.labelAvgPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPrice.Location = new System.Drawing.Point(363, 17);
            this.labelAvgPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvgPrice.Name = "labelAvgPrice";
            this.labelAvgPrice.Size = new System.Drawing.Size(97, 19);
            this.labelAvgPrice.TabIndex = 19;
            this.labelAvgPrice.Text = "Average Price:";
            // 
            // labelAvgTax
            // 
            this.labelAvgTax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAvgTax.AutoSize = true;
            this.labelAvgTax.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgTax.Location = new System.Drawing.Point(596, 17);
            this.labelAvgTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvgTax.Name = "labelAvgTax";
            this.labelAvgTax.Size = new System.Drawing.Size(88, 19);
            this.labelAvgTax.TabIndex = 20;
            this.labelAvgTax.Text = "Average Tax:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(225, 12);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(133, 29);
            this.textBoxPrice.TabIndex = 22;
            // 
            // textBoxAvgPrice
            // 
            this.textBoxAvgPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAvgPrice.Location = new System.Drawing.Point(465, 12);
            this.textBoxAvgPrice.Name = "textBoxAvgPrice";
            this.textBoxAvgPrice.ReadOnly = true;
            this.textBoxAvgPrice.Size = new System.Drawing.Size(126, 29);
            this.textBoxAvgPrice.TabIndex = 23;
            // 
            // chartTypes
            // 
            this.chartTypes.BackColor = System.Drawing.SystemColors.Control;
            this.chartTypes.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartTypes.ChartAreas.Add(chartArea1);
            this.chartTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTypes.Location = new System.Drawing.Point(3, 3);
            this.chartTypes.Name = "chartTypes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieDrawingStyle=SoftEdge, PieLabelStyle=Outside";
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series1.IsValueShownAsLabel = true;
            series1.Name = "Type";
            series1.YValuesPerPoint = 2;
            this.chartTypes.Series.Add(series1);
            this.chartTypes.Size = new System.Drawing.Size(622, 420);
            this.chartTypes.TabIndex = 28;
            this.chartTypes.Text = "Type";
            // 
            // chartPrice
            // 
            this.chartPrice.BackColor = System.Drawing.SystemColors.Control;
            this.chartPrice.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartPrice.ChartAreas.Add(chartArea2);
            this.chartPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPrice.Location = new System.Drawing.Point(631, 3);
            this.chartPrice.Name = "chartPrice";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.chartPrice.Series.Add(series2);
            this.chartPrice.Size = new System.Drawing.Size(623, 420);
            this.chartPrice.TabIndex = 29;
            this.chartPrice.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.716586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.75523F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.589372F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.77295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.059581F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.49759F));
            this.tableLayoutPanel1.Controls.Add(this.labelShow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonAll, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonPeriod, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFrom, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShow, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1257, 64);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.labelFilter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTransactionType, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelAddedBy, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxAddedBy, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxDealCust, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1257, 64);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dgvOrders, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 128);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1257, 355);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // textBoxAvgTax
            // 
            this.textBoxAvgTax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAvgTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAvgTax.Location = new System.Drawing.Point(689, 12);
            this.textBoxAvgTax.Name = "textBoxAvgTax";
            this.textBoxAvgTax.ReadOnly = true;
            this.textBoxAvgTax.Size = new System.Drawing.Size(88, 29);
            this.textBoxAvgTax.TabIndex = 24;
            // 
            // labelDisco
            // 
            this.labelDisco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDisco.AutoSize = true;
            this.labelDisco.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisco.Location = new System.Drawing.Point(782, 17);
            this.labelDisco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisco.Name = "labelDisco";
            this.labelDisco.Size = new System.Drawing.Size(115, 19);
            this.labelDisco.TabIndex = 21;
            this.labelDisco.Text = "Average Disount:";
            // 
            // textBoxDisco
            // 
            this.textBoxDisco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDisco.Location = new System.Drawing.Point(902, 12);
            this.textBoxDisco.Name = "textBoxDisco";
            this.textBoxDisco.ReadOnly = true;
            this.textBoxDisco.Size = new System.Drawing.Size(87, 29);
            this.textBoxDisco.TabIndex = 25;
            // 
            // labelItems
            // 
            this.labelItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(994, 17);
            this.labelItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(121, 19);
            this.labelItems.TabIndex = 26;
            this.labelItems.Text = "Number Of Items:";
            // 
            // textBoxItems
            // 
            this.textBoxItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItems.Location = new System.Drawing.Point(1120, 12);
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.ReadOnly = true;
            this.textBoxItems.Size = new System.Drawing.Size(87, 29);
            this.textBoxItems.TabIndex = 27;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 12;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.lblTotal, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxItems, 11, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelAvgTax, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxAvgTax, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelItems, 10, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxAvgPrice, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelDisco, 8, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxDisco, 9, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelAvgPrice, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelPrice, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxPrice, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 483);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1257, 53);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.chartTypes, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.chartPrice, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 536);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1257, 426);
            this.tableLayoutPanel5.TabIndex = 34;
            // 
            // formOrderReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 962);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formOrderReference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formOrderReference";
            this.Load += new System.EventHandler(this.formOrderReference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonPeriod;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label labelAddedBy;
        private System.Windows.Forms.ComboBox comboBoxAddedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDealCust;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAvgPrice;
        private System.Windows.Forms.Label labelAvgTax;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAvgPrice;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTypes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxAvgTax;
        private System.Windows.Forms.Label labelDisco;
        private System.Windows.Forms.TextBox textBoxDisco;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}