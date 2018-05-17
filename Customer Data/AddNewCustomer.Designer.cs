namespace Customer_Data
{
    partial class AddNewCustomer
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
            this.components = new System.ComponentModel.Container();
            this.Txb_FirstName = new System.Windows.Forms.TextBox();
            this.Txb_MoneyAccount = new System.Windows.Forms.TextBox();
            this.Txb_EmailAddress = new System.Windows.Forms.TextBox();
            this.Txb_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_SaveCustomer = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.EP_ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EP_ErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_FirstName
            // 
            this.Txb_FirstName.Location = new System.Drawing.Point(32, 44);
            this.Txb_FirstName.Name = "Txb_FirstName";
            this.Txb_FirstName.Size = new System.Drawing.Size(209, 20);
            this.Txb_FirstName.TabIndex = 0;
            this.Txb_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_FirstName_Validating);
            // 
            // Txb_MoneyAccount
            // 
            this.Txb_MoneyAccount.Location = new System.Drawing.Point(270, 99);
            this.Txb_MoneyAccount.Name = "Txb_MoneyAccount";
            this.Txb_MoneyAccount.Size = new System.Drawing.Size(209, 20);
            this.Txb_MoneyAccount.TabIndex = 2;
            this.Txb_MoneyAccount.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_MoneyAccount_Validating);
            // 
            // Txb_EmailAddress
            // 
            this.Txb_EmailAddress.Location = new System.Drawing.Point(32, 99);
            this.Txb_EmailAddress.Name = "Txb_EmailAddress";
            this.Txb_EmailAddress.Size = new System.Drawing.Size(209, 20);
            this.Txb_EmailAddress.TabIndex = 3;
            this.Txb_EmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_EmailAddress_Validating);
            // 
            // Txb_LastName
            // 
            this.Txb_LastName.Location = new System.Drawing.Point(270, 44);
            this.Txb_LastName.Name = "Txb_LastName";
            this.Txb_LastName.Size = new System.Drawing.Size(209, 20);
            this.Txb_LastName.TabIndex = 4;
            this.Txb_LastName.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_LastName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Money in the Account";
            // 
            // Btn_SaveCustomer
            // 
            this.Btn_SaveCustomer.Location = new System.Drawing.Point(32, 136);
            this.Btn_SaveCustomer.Name = "Btn_SaveCustomer";
            this.Btn_SaveCustomer.Size = new System.Drawing.Size(145, 26);
            this.Btn_SaveCustomer.TabIndex = 9;
            this.Btn_SaveCustomer.Text = "Save";
            this.Btn_SaveCustomer.UseVisualStyleBackColor = true;
            this.Btn_SaveCustomer.Click += new System.EventHandler(this.Btn_SaveCustomer_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(32, 168);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(145, 26);
            this.Btn_Close.TabIndex = 10;
            this.Btn_Close.Text = "Quit";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // EP_ErrorMessage
            // 
            this.EP_ErrorMessage.ContainerControl = this;
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 224);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_SaveCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_LastName);
            this.Controls.Add(this.Txb_EmailAddress);
            this.Controls.Add(this.Txb_MoneyAccount);
            this.Controls.Add(this.Txb_FirstName);
            this.Name = "AddNewCustomer";
            this.Text = "AddNewCustomer";
            this.Load += new System.EventHandler(this.AddNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_ErrorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_FirstName;
        private System.Windows.Forms.TextBox Txb_MoneyAccount;
        private System.Windows.Forms.TextBox Txb_EmailAddress;
        private System.Windows.Forms.TextBox Txb_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_SaveCustomer;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ErrorProvider EP_ErrorMessage;
    }
}