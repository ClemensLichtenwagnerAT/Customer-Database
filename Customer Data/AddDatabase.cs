using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Customer_Data;

namespace Customer_Data
{
    public partial class AddDatabase : Form
    {
        private ListCustomer listCustomer = new ListCustomer();

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
                //Check if database was successfully created
                if (listCustomer.CreateNewDataBase(Txb_NameNewDatabase.Text, Txb_Password.Text))
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show(GlobalStrings.DBCreatedSuccesfully);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(GlobalStrings.FailureCreatingDatabase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
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
                    this.EP_ErrorMessage.SetError(Txb_NameNewDatabase, GlobalStrings.FailureInputTxbNames_Empty);
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

        private void Txb_Password_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Txb_Password.Text.Length == 0)
                {
                    this.EP_ErrorMessage.SetError(Txb_Password, GlobalStrings.FailureInputTxbNames_Empty);
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
