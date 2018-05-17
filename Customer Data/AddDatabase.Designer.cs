namespace Customer_Data
{
    partial class AddDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_NameNewDatabase = new System.Windows.Forms.TextBox();
            this.Txb_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_CreateDatabase = new System.Windows.Forms.Button();
            this.EP_ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EP_ErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the new database";
            // 
            // Txb_NameNewDatabase
            // 
            this.Txb_NameNewDatabase.Location = new System.Drawing.Point(16, 47);
            this.Txb_NameNewDatabase.Name = "Txb_NameNewDatabase";
            this.Txb_NameNewDatabase.Size = new System.Drawing.Size(142, 20);
            this.Txb_NameNewDatabase.TabIndex = 1;
            this.Txb_NameNewDatabase.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_NameNewDatabase_Validating);
            // 
            // Txb_Password
            // 
            this.Txb_Password.Location = new System.Drawing.Point(192, 47);
            this.Txb_Password.Name = "Txb_Password";
            this.Txb_Password.Size = new System.Drawing.Size(142, 20);
            this.Txb_Password.TabIndex = 2;
            this.Txb_Password.UseSystemPasswordChar = true;
            this.Txb_Password.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_Password_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(16, 123);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(100, 26);
            this.Btn_Close.TabIndex = 12;
            this.Btn_Close.Text = "Quit";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_CreateDatabase
            // 
            this.Btn_CreateDatabase.Location = new System.Drawing.Point(16, 91);
            this.Btn_CreateDatabase.Name = "Btn_CreateDatabase";
            this.Btn_CreateDatabase.Size = new System.Drawing.Size(100, 26);
            this.Btn_CreateDatabase.TabIndex = 11;
            this.Btn_CreateDatabase.Text = "Create Database";
            this.Btn_CreateDatabase.UseVisualStyleBackColor = true;
            this.Btn_CreateDatabase.Click += new System.EventHandler(this.Btn_CreateDatabase_Click);
            // 
            // EP_ErrorMessage
            // 
            this.EP_ErrorMessage.ContainerControl = this;
            // 
            // AddDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 164);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_CreateDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Password);
            this.Controls.Add(this.Txb_NameNewDatabase);
            this.Controls.Add(this.label1);
            this.Name = "AddDatabase";
            this.Text = "Add New Database";
            ((System.ComponentModel.ISupportInitialize)(this.EP_ErrorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_NameNewDatabase;
        private System.Windows.Forms.TextBox Txb_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_CreateDatabase;
        private System.Windows.Forms.ErrorProvider EP_ErrorMessage;
    }
}