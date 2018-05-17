using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Data
{
    public partial class OpenDatabase : Form
    {
        public OpenDatabase()
        {
            InitializeComponent();
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
                MessageBox.Show("Error loading the database! " + ex.Message);
            }
        }

        private void Btn_OpenChoosenDatabase_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            // Tobi: Prüfe ob Datenbank geöffnet werden kann
            this.Close();
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
    }
}
