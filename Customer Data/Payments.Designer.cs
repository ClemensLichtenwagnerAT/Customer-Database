namespace Customer_Data
{
    partial class Payments
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
            this.Btn_PayIn = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.Btn_PayOut = new System.Windows.Forms.Button();
            this.Txb_Amount = new System.Windows.Forms.TextBox();
            this.Lbl_Amount = new System.Windows.Forms.Label();
            this.EP_ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_LastName = new System.Windows.Forms.TextBox();
            this.Txb_EmailAddress = new System.Windows.Forms.TextBox();
            this.Txb_MoneyAccount = new System.Windows.Forms.TextBox();
            this.Txb_FirstName = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EP_ErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_PayIn
            // 
            this.Btn_PayIn.Location = new System.Drawing.Point(5, 166);
            this.Btn_PayIn.Name = "Btn_PayIn";
            this.Btn_PayIn.Size = new System.Drawing.Size(136, 30);
            this.Btn_PayIn.TabIndex = 0;
            this.Btn_PayIn.Text = "Pay in";
            this.Btn_PayIn.UseVisualStyleBackColor = true;
            this.Btn_PayIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(147, 202);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(136, 30);
            this.Btn_Quit.TabIndex = 1;
            this.Btn_Quit.Text = "Quit";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Btn_PayOut
            // 
            this.Btn_PayOut.Location = new System.Drawing.Point(147, 166);
            this.Btn_PayOut.Name = "Btn_PayOut";
            this.Btn_PayOut.Size = new System.Drawing.Size(136, 30);
            this.Btn_PayOut.TabIndex = 2;
            this.Btn_PayOut.Text = "Pay out";
            this.Btn_PayOut.UseVisualStyleBackColor = true;
            this.Btn_PayOut.Click += new System.EventHandler(this.Btn_PayOut_Click);
            // 
            // Txb_Amount
            // 
            this.Txb_Amount.Location = new System.Drawing.Point(5, 140);
            this.Txb_Amount.Name = "Txb_Amount";
            this.Txb_Amount.Size = new System.Drawing.Size(88, 20);
            this.Txb_Amount.TabIndex = 3;
            this.Txb_Amount.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_Amount_Validating);
            // 
            // Lbl_Amount
            // 
            this.Lbl_Amount.AutoSize = true;
            this.Lbl_Amount.Location = new System.Drawing.Point(2, 124);
            this.Lbl_Amount.Name = "Lbl_Amount";
            this.Lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Amount.TabIndex = 4;
            this.Lbl_Amount.Text = "Amount";
            // 
            // EP_ErrorMessage
            // 
            this.EP_ErrorMessage.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Money in the Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "E-mail address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "First name";
            // 
            // Txb_LastName
            // 
            this.Txb_LastName.Location = new System.Drawing.Point(243, 28);
            this.Txb_LastName.Name = "Txb_LastName";
            this.Txb_LastName.ReadOnly = true;
            this.Txb_LastName.Size = new System.Drawing.Size(209, 20);
            this.Txb_LastName.TabIndex = 22;
            // 
            // Txb_EmailAddress
            // 
            this.Txb_EmailAddress.Location = new System.Drawing.Point(5, 83);
            this.Txb_EmailAddress.Name = "Txb_EmailAddress";
            this.Txb_EmailAddress.ReadOnly = true;
            this.Txb_EmailAddress.Size = new System.Drawing.Size(209, 20);
            this.Txb_EmailAddress.TabIndex = 21;
            // 
            // Txb_MoneyAccount
            // 
            this.Txb_MoneyAccount.Location = new System.Drawing.Point(243, 83);
            this.Txb_MoneyAccount.Name = "Txb_MoneyAccount";
            this.Txb_MoneyAccount.ReadOnly = true;
            this.Txb_MoneyAccount.Size = new System.Drawing.Size(209, 20);
            this.Txb_MoneyAccount.TabIndex = 20;
            // 
            // Txb_FirstName
            // 
            this.Txb_FirstName.Location = new System.Drawing.Point(5, 28);
            this.Txb_FirstName.Name = "Txb_FirstName";
            this.Txb_FirstName.ReadOnly = true;
            this.Txb_FirstName.Size = new System.Drawing.Size(209, 20);
            this.Txb_FirstName.TabIndex = 19;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(5, 202);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(136, 30);
            this.Btn_Save.TabIndex = 27;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 270);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_LastName);
            this.Controls.Add(this.Txb_EmailAddress);
            this.Controls.Add(this.Txb_MoneyAccount);
            this.Controls.Add(this.Txb_FirstName);
            this.Controls.Add(this.Lbl_Amount);
            this.Controls.Add(this.Txb_Amount);
            this.Controls.Add(this.Btn_PayOut);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_PayIn);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_ErrorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_PayIn;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Button Btn_PayOut;
        private System.Windows.Forms.TextBox Txb_Amount;
        private System.Windows.Forms.Label Lbl_Amount;
        private System.Windows.Forms.ErrorProvider EP_ErrorMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_LastName;
        private System.Windows.Forms.TextBox Txb_EmailAddress;
        private System.Windows.Forms.TextBox Txb_MoneyAccount;
        private System.Windows.Forms.TextBox Txb_FirstName;
        private System.Windows.Forms.Button Btn_Save;
    }
}