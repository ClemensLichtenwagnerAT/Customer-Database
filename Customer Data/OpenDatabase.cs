using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer_Data;

namespace Customer_Data
{
    public partial class OpenDatabase : Form
    {
        private ListCustomer CustomerList = new ListCustomer();

        public OpenDatabase(ListCustomer customerList)
        {
            InitializeComponent();
            CustomerList = customerList;
        }

        public string GetDataBaseName
        {
            get
            {
                return this.Txb_ChoosenDatabase.Text;
            }
        }

        public string GetPasswordforDatabase
        {
            get
            {
                return this.Txb_EnterPassword.Text;
            }
        }

        private void Btn_SearchDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog_Database = new OpenFileDialog();
                openFileDialog_Database.InitialDirectory = "c:\\Datenbanken\\";
                openFileDialog_Database.Filter = "txt files (*.csv)|*.csv";
                openFileDialog_Database.FilterIndex = 2;
                openFileDialog_Database.RestoreDirectory = true;

                if (openFileDialog_Database.ShowDialog() == DialogResult.OK)
                {
                    this.Txb_ChoosenDatabase.Text = openFileDialog_Database.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_OpenChoosenDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerList.LoadDataBase(Txb_ChoosenDatabase.Text, Txb_EnterPassword.Text))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
               else
                {
                    MessageBox.Show(GlobalStrings.FailureOpenDatabase);
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

        private void OpenDatabase_Load(object sender, EventArgs e)
        {
            // set language
            this.Text = GlobalStrings.FormOpenDatabase;
            label1.Text = GlobalStrings.LblChoosenDatabase;
            label2.Text = GlobalStrings.LblPassword;
            Btn_Close.Text = GlobalStrings.Btn_QuitText;
            Btn_OpenChoosenDatabase.Text = GlobalStrings.BtnOpenChoosenDatabase;
            Btn_SearchDatabase.Text = GlobalStrings.BtnSearchDatabase;
        }
    }
}
