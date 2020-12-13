namespace Shop_Store_System.Design_Interfaces
{
    partial class formInventory
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.labelCategory = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 70);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1165, 453);
            this.dgvProducts.TabIndex = 0;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(29, 25);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(85, 23);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category:";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(131, 22);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(438, 31);
            this.cmbCategories.TabIndex = 2;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(605, 13);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(128, 47);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // formInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 535);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.dgvProducts);
            this.Name = "formInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.formInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnAll;
    }
}