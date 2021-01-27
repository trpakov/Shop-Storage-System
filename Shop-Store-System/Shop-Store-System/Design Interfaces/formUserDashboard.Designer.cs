namespace Shop_Store_System
{
    partial class formUserDashboard
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAppLName = new System.Windows.Forms.Label();
            this.labelAppFName = new System.Windows.Forms.Label();
            this.labelLoggedUser = new System.Windows.Forms.Label();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.lowQuantityProducts = new System.Windows.Forms.DataGridView();
            this.tableLabel = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowQuantityProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem,
            this.logisticToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripTop.Size = new System.Drawing.Size(1042, 24);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // logisticToolStripMenuItem
            // 
            this.logisticToolStripMenuItem.Name = "logisticToolStripMenuItem";
            this.logisticToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.logisticToolStripMenuItem.Text = "Delivery";
            this.logisticToolStripMenuItem.Click += new System.EventHandler(this.logisticToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(659, 400);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(218, 19);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Billing and Inventory Managment";
            // 
            // labelAppLName
            // 
            this.labelAppLName.AutoSize = true;
            this.labelAppLName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppLName.Location = new System.Drawing.Point(790, 362);
            this.labelAppLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppLName.Name = "labelAppLName";
            this.labelAppLName.Size = new System.Drawing.Size(110, 37);
            this.labelAppLName.TabIndex = 10;
            this.labelAppLName.Text = "System";
            // 
            // labelAppFName
            // 
            this.labelAppFName.AutoSize = true;
            this.labelAppFName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppFName.Location = new System.Drawing.Point(644, 362);
            this.labelAppFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppFName.Name = "labelAppFName";
            this.labelAppFName.Size = new System.Drawing.Size(152, 37);
            this.labelAppFName.TabIndex = 9;
            this.labelAppFName.Text = "Shop Store";
            // 
            // labelLoggedUser
            // 
            this.labelLoggedUser.AutoSize = true;
            this.labelLoggedUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelLoggedUser.Location = new System.Drawing.Point(50, 28);
            this.labelLoggedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoggedUser.Name = "labelLoggedUser";
            this.labelLoggedUser.Size = new System.Drawing.Size(55, 19);
            this.labelLoggedUser.TabIndex = 8;
            this.labelLoggedUser.Text = "Georgi";
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUser.Location = new System.Drawing.Point(9, 28);
            this.labelLoginUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(40, 19);
            this.labelLoginUser.TabIndex = 7;
            this.labelLoginUser.Text = "User:";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Teal;
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 461);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1042, 39);
            this.panelFooter.TabIndex = 12;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.White;
            this.labelFooter.Location = new System.Drawing.Point(676, 9);
            this.labelFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(188, 21);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Text = "Developed by: Group 12";
            // 
            // lowQuantityProducts
            // 
            this.lowQuantityProducts.AllowUserToAddRows = false;
            this.lowQuantityProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowQuantityProducts.Location = new System.Drawing.Point(9, 72);
            this.lowQuantityProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lowQuantityProducts.Name = "lowQuantityProducts";
            this.lowQuantityProducts.ReadOnly = true;
            this.lowQuantityProducts.RowHeadersVisible = false;
            this.lowQuantityProducts.RowHeadersWidth = 51;
            this.lowQuantityProducts.RowTemplate.Height = 24;
            this.lowQuantityProducts.Size = new System.Drawing.Size(808, 266);
            this.lowQuantityProducts.TabIndex = 13;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(11, 56);
            this.tableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(138, 13);
            this.tableLabel.TabIndex = 14;
            this.tableLabel.Text = "No products in low quantity!";
            // 
            // formUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 500);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.lowQuantityProducts);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAppLName);
            this.Controls.Add(this.labelAppFName);
            this.Controls.Add(this.labelLoggedUser);
            this.Controls.Add(this.labelLoginUser);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formUserDashboard_FormClosed);
            this.Load += new System.EventHandler(this.formUserDashboard_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowQuantityProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAppLName;
        private System.Windows.Forms.Label labelAppFName;
        private System.Windows.Forms.Label labelLoggedUser;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label tableLabel;
        public System.Windows.Forms.DataGridView lowQuantityProducts;
    }
}