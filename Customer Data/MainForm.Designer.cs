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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_SetLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.DataGridView_CustomerList = new System.Windows.Forms.DataGridView();
            this.Column_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OpenBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Database = new System.Windows.Forms.Label();
            this.Lbl_NameDatabase = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.extrasToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDatabaseToolStripMenuItem,
            this.openDatabaseToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            resources.ApplyResources(this.dateiToolStripMenuItem, "dateiToolStripMenuItem");
            // 
            // addDatabaseToolStripMenuItem
            // 
            this.addDatabaseToolStripMenuItem.Name = "addDatabaseToolStripMenuItem";
            resources.ApplyResources(this.addDatabaseToolStripMenuItem, "addDatabaseToolStripMenuItem");
            this.addDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addDatabaseToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            resources.ApplyResources(this.openDatabaseToolStripMenuItem, "openDatabaseToolStripMenuItem");
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem1,
            this.showCustomerListToolStripMenuItem,
            this.hideCustomerListToolStripMenuItem1});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            resources.ApplyResources(this.databaseToolStripMenuItem, "databaseToolStripMenuItem");
            // 
            // addCustomerToolStripMenuItem1
            // 
            this.addCustomerToolStripMenuItem1.Name = "addCustomerToolStripMenuItem1";
            resources.ApplyResources(this.addCustomerToolStripMenuItem1, "addCustomerToolStripMenuItem1");
            this.addCustomerToolStripMenuItem1.Click += new System.EventHandler(this.addCustomerToolStripMenuItem1_Click);
            // 
            // showCustomerListToolStripMenuItem
            // 
            this.showCustomerListToolStripMenuItem.Name = "showCustomerListToolStripMenuItem";
            resources.ApplyResources(this.showCustomerListToolStripMenuItem, "showCustomerListToolStripMenuItem");
            this.showCustomerListToolStripMenuItem.Click += new System.EventHandler(this.showCustomerListToolStripMenuItem_Click);
            // 
            // hideCustomerListToolStripMenuItem1
            // 
            this.hideCustomerListToolStripMenuItem1.Name = "hideCustomerListToolStripMenuItem1";
            resources.ApplyResources(this.hideCustomerListToolStripMenuItem1, "hideCustomerListToolStripMenuItem1");
            this.hideCustomerListToolStripMenuItem1.Click += new System.EventHandler(this.hideCustomerListToolStripMenuItem1_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentsToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            resources.ApplyResources(this.extrasToolStripMenuItem, "extrasToolStripMenuItem");
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            resources.ApplyResources(this.paymentsToolStripMenuItem, "paymentsToolStripMenuItem");
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_SetLanguage});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // toolStripComboBox_SetLanguage
            // 
            this.toolStripComboBox_SetLanguage.Name = "toolStripComboBox_SetLanguage";
            resources.ApplyResources(this.toolStripComboBox_SetLanguage, "toolStripComboBox_SetLanguage");
            this.toolStripComboBox_SetLanguage.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SetLanguage_SelectedIndexChanged);
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
            resources.ApplyResources(this.DataGridView_CustomerList, "DataGridView_CustomerList");
            this.DataGridView_CustomerList.Name = "DataGridView_CustomerList";
            // 
            // Column_FirstName
            // 
            this.Column_FirstName.Frozen = true;
            resources.ApplyResources(this.Column_FirstName, "Column_FirstName");
            this.Column_FirstName.Name = "Column_FirstName";
            this.Column_FirstName.ReadOnly = true;
            // 
            // Column_LastName
            // 
            resources.ApplyResources(this.Column_LastName, "Column_LastName");
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.ReadOnly = true;
            // 
            // Column_EmailAddress
            // 
            resources.ApplyResources(this.Column_EmailAddress, "Column_EmailAddress");
            this.Column_EmailAddress.Name = "Column_EmailAddress";
            this.Column_EmailAddress.ReadOnly = true;
            // 
            // Column_OpenBalance
            // 
            resources.ApplyResources(this.Column_OpenBalance, "Column_OpenBalance");
            this.Column_OpenBalance.Name = "Column_OpenBalance";
            this.Column_OpenBalance.ReadOnly = true;
            // 
            // Column_LastChange
            // 
            resources.ApplyResources(this.Column_LastChange, "Column_LastChange");
            this.Column_LastChange.Name = "Column_LastChange";
            this.Column_LastChange.ReadOnly = true;
            // 
            // Lbl_Database
            // 
            resources.ApplyResources(this.Lbl_Database, "Lbl_Database");
            this.Lbl_Database.Name = "Lbl_Database";
            // 
            // Lbl_NameDatabase
            // 
            resources.ApplyResources(this.Lbl_NameDatabase, "Lbl_NameDatabase");
            this.Lbl_NameDatabase.Name = "Lbl_NameDatabase";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_NameDatabase);
            this.Controls.Add(this.Lbl_Database);
            this.Controls.Add(this.DataGridView_CustomerList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_SetLanguage;
        private System.Windows.Forms.Label Lbl_Database;
        private System.Windows.Forms.Label Lbl_NameDatabase;
    }
}

