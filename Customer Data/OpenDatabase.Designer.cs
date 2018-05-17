namespace Customer_Data
{
    partial class OpenDatabase
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_EnterPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_SearchDatabase = new System.Windows.Forms.Button();
            this.Txb_ChoosenDatabase = new System.Windows.Forms.TextBox();
            this.Btn_OpenChoosenDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(206, 140);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(117, 30);
            this.Btn_Close.TabIndex = 11;
            this.Btn_Close.Text = "Quit";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // Txb_EnterPassword
            // 
            this.Txb_EnterPassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_EnterPassword.Location = new System.Drawing.Point(206, 48);
            this.Txb_EnterPassword.Name = "Txb_EnterPassword";
            this.Txb_EnterPassword.Size = new System.Drawing.Size(165, 23);
            this.Txb_EnterPassword.TabIndex = 12;
            this.Txb_EnterPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Choosen Database ";
            // 
            // Btn_SearchDatabase
            // 
            this.Btn_SearchDatabase.Location = new System.Drawing.Point(17, 77);
            this.Btn_SearchDatabase.Name = "Btn_SearchDatabase";
            this.Btn_SearchDatabase.Size = new System.Drawing.Size(164, 30);
            this.Btn_SearchDatabase.TabIndex = 17;
            this.Btn_SearchDatabase.Text = "Search Database";
            this.Btn_SearchDatabase.UseVisualStyleBackColor = true;
            this.Btn_SearchDatabase.Click += new System.EventHandler(this.Btn_SearchDatabase_Click);
            // 
            // Txb_ChoosenDatabase
            // 
            this.Txb_ChoosenDatabase.Location = new System.Drawing.Point(17, 48);
            this.Txb_ChoosenDatabase.Name = "Txb_ChoosenDatabase";
            this.Txb_ChoosenDatabase.Size = new System.Drawing.Size(164, 23);
            this.Txb_ChoosenDatabase.TabIndex = 18;
            // 
            // Btn_OpenChoosenDatabase
            // 
            this.Btn_OpenChoosenDatabase.Location = new System.Drawing.Point(17, 140);
            this.Btn_OpenChoosenDatabase.Name = "Btn_OpenChoosenDatabase";
            this.Btn_OpenChoosenDatabase.Size = new System.Drawing.Size(164, 30);
            this.Btn_OpenChoosenDatabase.TabIndex = 19;
            this.Btn_OpenChoosenDatabase.Text = "Open choosen Database";
            this.Btn_OpenChoosenDatabase.UseVisualStyleBackColor = true;
            this.Btn_OpenChoosenDatabase.Click += new System.EventHandler(this.Btn_OpenChoosenDatabase_Click);
            // 
            // OpenDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 183);
            this.Controls.Add(this.Btn_OpenChoosenDatabase);
            this.Controls.Add(this.Txb_ChoosenDatabase);
            this.Controls.Add(this.Btn_SearchDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_EnterPassword);
            this.Controls.Add(this.Btn_Close);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OpenDatabase";
            this.Text = "Open Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_EnterPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_SearchDatabase;
        private System.Windows.Forms.TextBox Txb_ChoosenDatabase;
        private System.Windows.Forms.Button Btn_OpenChoosenDatabase;
    }
}