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
            ((System.ComponentModel.ISupportInitialize)(this.EP_ErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_PayIn
            // 
            this.Btn_PayIn.Location = new System.Drawing.Point(12, 70);
            this.Btn_PayIn.Name = "Btn_PayIn";
            this.Btn_PayIn.Size = new System.Drawing.Size(136, 30);
            this.Btn_PayIn.TabIndex = 0;
            this.Btn_PayIn.Text = "Pay in";
            this.Btn_PayIn.UseVisualStyleBackColor = true;
            this.Btn_PayIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(154, 106);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(121, 30);
            this.Btn_Quit.TabIndex = 1;
            this.Btn_Quit.Text = "Quit";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Btn_PayOut
            // 
            this.Btn_PayOut.Location = new System.Drawing.Point(12, 106);
            this.Btn_PayOut.Name = "Btn_PayOut";
            this.Btn_PayOut.Size = new System.Drawing.Size(136, 30);
            this.Btn_PayOut.TabIndex = 2;
            this.Btn_PayOut.Text = "Pay out";
            this.Btn_PayOut.UseVisualStyleBackColor = true;
            this.Btn_PayOut.Click += new System.EventHandler(this.Btn_PayOut_Click);
            // 
            // Txb_Amount
            // 
            this.Txb_Amount.Location = new System.Drawing.Point(12, 44);
            this.Txb_Amount.Name = "Txb_Amount";
            this.Txb_Amount.Size = new System.Drawing.Size(88, 20);
            this.Txb_Amount.TabIndex = 3;
            this.Txb_Amount.Validating += new System.ComponentModel.CancelEventHandler(this.Txb_Amount_Validating);
            // 
            // Lbl_Amount
            // 
            this.Lbl_Amount.AutoSize = true;
            this.Lbl_Amount.Location = new System.Drawing.Point(9, 28);
            this.Lbl_Amount.Name = "Lbl_Amount";
            this.Lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Amount.TabIndex = 4;
            this.Lbl_Amount.Text = "Amount";
            // 
            // EP_ErrorMessage
            // 
            this.EP_ErrorMessage.ContainerControl = this;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 196);
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
    }
}