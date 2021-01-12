namespace Shop_Store_System.Design_Interfaces
{
    partial class formPersonalLogistic
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
            this.btnAll = new System.Windows.Forms.Button();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dgvLogistic = new System.Windows.Forms.DataGridView();
            this.btnDelivered = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogistic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(515, 17);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(132, 42);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
            this.cmbDate.Location = new System.Drawing.Point(95, 24);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(389, 31);
            this.cmbDate.TabIndex = 5;
            this.cmbDate.SelectedIndexChanged += new System.EventHandler(this.cmbDate_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(39, 27);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(50, 23);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
            // 
            // dgvLogistic
            // 
            this.dgvLogistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogistic.Location = new System.Drawing.Point(12, 73);
            this.dgvLogistic.Name = "dgvLogistic";
            this.dgvLogistic.RowHeadersWidth = 51;
            this.dgvLogistic.RowTemplate.Height = 24;
            this.dgvLogistic.Size = new System.Drawing.Size(1326, 453);
            this.dgvLogistic.TabIndex = 7;
            this.dgvLogistic.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLogistic_RowHeaderMouseClick);
            // 
            // btnDelivered
            // 
            this.btnDelivered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivered.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivered.Location = new System.Drawing.Point(665, 17);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(132, 42);
            this.btnDelivered.TabIndex = 8;
            this.btnDelivered.Text = "Delivered";
            this.btnDelivered.UseVisualStyleBackColor = false;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // formPersonalLogistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 538);
            this.Controls.Add(this.dgvLogistic);
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.labelDate);
            this.Name = "formPersonalLogistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Logistic";
            this.Load += new System.EventHandler(this.formPersonalLogistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView dgvLogistic;
        private System.Windows.Forms.Button btnDelivered;
    }
}