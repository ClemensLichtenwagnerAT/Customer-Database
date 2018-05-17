namespace Customer_Data
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideCustomerListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Customers = new System.Windows.Forms.Label();
            this.DataGridView_CustomerList = new System.Windows.Forms.DataGridView();
            this.Column_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OpenBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.extrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDatabaseToolStripMenuItem,
            this.openDatabaseToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dateiToolStripMenuItem.Text = "Start";
            // 
            // addDatabaseToolStripMenuItem
            // 
            this.addDatabaseToolStripMenuItem.Name = "addDatabaseToolStripMenuItem";
            this.addDatabaseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addDatabaseToolStripMenuItem.Text = "Add Database";
            this.addDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addDatabaseToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem1,
            this.showCustomerListToolStripMenuItem,
            this.hideCustomerListToolStripMenuItem1});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // addCustomerToolStripMenuItem1
            // 
            this.addCustomerToolStripMenuItem1.Name = "addCustomerToolStripMenuItem1";
            this.addCustomerToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.addCustomerToolStripMenuItem1.Text = "Add Customer";
            this.addCustomerToolStripMenuItem1.Click += new System.EventHandler(this.addCustomerToolStripMenuItem1_Click);
            // 
            // showCustomerListToolStripMenuItem
            // 
            this.showCustomerListToolStripMenuItem.Name = "showCustomerListToolStripMenuItem";
            this.showCustomerListToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.showCustomerListToolStripMenuItem.Text = "Show Customer List";
            this.showCustomerListToolStripMenuItem.Click += new System.EventHandler(this.showCustomerListToolStripMenuItem_Click);
            // 
            // hideCustomerListToolStripMenuItem1
            // 
            this.hideCustomerListToolStripMenuItem1.Name = "hideCustomerListToolStripMenuItem1";
            this.hideCustomerListToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.hideCustomerListToolStripMenuItem1.Text = "Hide Customer List";
            this.hideCustomerListToolStripMenuItem1.Click += new System.EventHandler(this.hideCustomerListToolStripMenuItem1_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentsToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.paymentsToolStripMenuItem.Text = "Payments";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // Lbl_Customers
            // 
            this.Lbl_Customers.AutoSize = true;
            this.Lbl_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Customers.Location = new System.Drawing.Point(14, 45);
            this.Lbl_Customers.Name = "Lbl_Customers";
            this.Lbl_Customers.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Customers.TabIndex = 3;
            this.Lbl_Customers.Text = "Stored customers";
            // 
            // DataGridView_CustomerList
            // 
            this.DataGridView_CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_CustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_FirstName,
            this.Column_LastName,
            this.Column_EmailAddress,
            this.Column_OpenBalance,
            this.Column_LastChange});
            this.DataGridView_CustomerList.Location = new System.Drawing.Point(19, 72);
            this.DataGridView_CustomerList.Name = "DataGridView_CustomerList";
            this.DataGridView_CustomerList.Size = new System.Drawing.Size(730, 443);
            this.DataGridView_CustomerList.TabIndex = 5;
            // 
            // Column_FirstName
            // 
            this.Column_FirstName.Frozen = true;
            this.Column_FirstName.HeaderText = "First name";
            this.Column_FirstName.Name = "Column_FirstName";
            this.Column_FirstName.ReadOnly = true;
            this.Column_FirstName.Width = 150;
            // 
            // Column_LastName
            // 
            this.Column_LastName.HeaderText = "Last name";
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.ReadOnly = true;
            this.Column_LastName.Width = 150;
            // 
            // Column_EmailAddress
            // 
            this.Column_EmailAddress.HeaderText = "E-mail address";
            this.Column_EmailAddress.Name = "Column_EmailAddress";
            this.Column_EmailAddress.ReadOnly = true;
            this.Column_EmailAddress.Width = 150;
            // 
            // Column_OpenBalance
            // 
            this.Column_OpenBalance.HeaderText = "Open Balance";
            this.Column_OpenBalance.Name = "Column_OpenBalance";
            this.Column_OpenBalance.ReadOnly = true;
            this.Column_OpenBalance.Width = 80;
            // 
            // Column_LastChange
            // 
            this.Column_LastChange.HeaderText = "Last change";
            this.Column_LastChange.Name = "Column_LastChange";
            this.Column_LastChange.ReadOnly = true;
            this.Column_LastChange.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(777, 472);
            this.Controls.Add(this.DataGridView_CustomerList);
            this.Controls.Add(this.Lbl_Customers);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Customer Database";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_Customers;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGridView_CustomerList;
        private System.Windows.Forms.ToolStripMenuItem addDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideCustomerListToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OpenBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastChange;
    }
}

