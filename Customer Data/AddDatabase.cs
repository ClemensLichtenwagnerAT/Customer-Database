using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Customer_Data
{
    public partial class AddDatabase : Form
    {

        public AddDatabase()
        {
            InitializeComponent();
        }

        #region Properties
        public string NameDatabase
        {
            get
            {
                return this.Txb_NameNewDatabase.Text;
            }
        }

        public string Password
        {
            get
            {
                return this.Txb_Password.Text;
            }
        }
        #endregion


        private void Btn_CreateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating Database! " + ex.Message);
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txb_NameNewDatabase_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Txb_NameNewDatabase.Text.Length == 0)
                {
                    this.EP_ErrorMessage.SetError(Txb_NameNewDatabase, "Database name must have a least one character!");
                    e.Cancel = true;
                }
                else
                {
                    this.EP_ErrorMessage.Clear();
                    e.Cancel = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txb_Password_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Txb_NameNewDatabase.Text.Length == 0)
                {
                    this.EP_ErrorMessage.SetError(Txb_Password, "Password must have a least one character!");
                    e.Cancel = true;
                }
                else
                {
                    this.EP_ErrorMessage.Clear();
                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddDatabase_Load(object sender, EventArgs e)
        {
            this.Text = GlobalStrings.FormAddDatabase;
            Btn_Close.Text = GlobalStrings.Btn_QuitText;
            Btn_CreateDatabase.Text = GlobalStrings.Btn_CreateDatabaseText;
            label1.Text = GlobalStrings.Lbl_NameNewDatabaseText;
            label2.Text = GlobalStrings.Lbl_PasswordText;
        }
    }
}
