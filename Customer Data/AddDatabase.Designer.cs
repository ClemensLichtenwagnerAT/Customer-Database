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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDatabase));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Txb_NameNewDatabase
            // 
            resources.ApplyResources(this.Txb_NameNewDatabase, "Txb_NameNewDatabase");
            this.Txb_NameNewDatabase.Name = "Txb_NameNewDatabase";
            this.Txb_NameNewDatabase.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_NameNewDatabase_Validating);
            // 
            // Txb_Password
            // 
            resources.ApplyResources(this.Txb_Password, "Txb_Password");
            this.Txb_Password.Name = "Txb_Password";
            this.Txb_Password.UseSystemPasswordChar = true;
            this.Txb_Password.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_Password_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Btn_Close
            // 
            resources.ApplyResources(this.Btn_Close, "Btn_Close");
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_CreateDatabase
            // 
            resources.ApplyResources(this.Btn_CreateDatabase, "Btn_CreateDatabase");
            this.Btn_CreateDatabase.Name = "Btn_CreateDatabase";
            this.Btn_CreateDatabase.UseVisualStyleBackColor = true;
            this.Btn_CreateDatabase.Click += new System.EventHandler(this.Btn_CreateDatabase_Click);
            // 
            // EP_ErrorMessage
            // 
            this.EP_ErrorMessage.ContainerControl = this;
            // 
            // AddDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_CreateDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Password);
            this.Controls.Add(this.Txb_NameNewDatabase);
            this.Controls.Add(this.label1);
            this.Name = "AddDatabase";
            this.Load += new System.EventHandler(this.AddDatabase_Load);
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