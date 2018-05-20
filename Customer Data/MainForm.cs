using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using Customer_Data;

namespace Customer_Data
{
    public partial class MainForm : Form
    {
        private ListCustomer ListCustomer = new ListCustomer();
        private bool IsDatabaseSelected = false;

        public MainForm()
        {
            InitializeComponent();
            DataGridView_CustomerList.Visible = false;
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Payments dialog = new Payments();
                dialog.ShowDialog();
                //Check if Dialog Result was okey
                // if yes -> update datagridview and database
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsDatabaseSelected)
                {
                    AddNewCustomer dialog = new AddNewCustomer(ListCustomer);
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    {
                        IsDatabaseSelected = true;
                        // enter the data of the new user in the DataGridView
                        string[] columnData = new string[] {
                        dialog.GetNewCustomer.FirstName,
                        dialog.GetNewCustomer.LastName,
                        dialog.GetNewCustomer.EmailAddress,
                        dialog.GetNewCustomer.OpenBalance.ToString() + "€",
                        dialog.GetNewCustomer.LastChange.ToString() };
                        ListCustomer.UpdateDatabase();
                        DataGridView_CustomerList.Rows.Add(columnData);
                    }
                    else
                    {
                        MessageBox.Show(GlobalStrings.FailureAddCustomer);
                    }
                }
                else
                {
                    MessageBox.Show(GlobalStrings.NoDatabaseSelected);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showCustomerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView_CustomerList.Visible = true;
        }

        private void hideCustomerListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridView_CustomerList.Visible = false;
        }

        private void addDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView_CustomerList.ClearSelection();
                AddDatabase dialog = new AddDatabase();
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    ListCustomer.LoadDataBase(dialog.NameDatabase + ".csv", dialog.Password);
                    IsDatabaseSelected = true;
                    Lbl_NameDatabase.Text = dialog.NameDatabase;
                    DataGridView_CustomerList.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListCustomer ListCustomer = new ListCustomer();
                DataGridView_CustomerList.ClearSelection();
                OpenDatabase dialog = new OpenDatabase(ListCustomer);
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    IsDatabaseSelected = true;
                    Lbl_NameDatabase.Text = dialog.GetDataBaseName;
                    ListCustomer.LoadDataBase(dialog.GetDataBaseName, dialog.GetPasswordforDatabase);
                    foreach (var customer in ListCustomer.List)
                    {
                        string[] columnData = new string[] { customer.FirstName,
                        customer.LastName,
                        customer.EmailAddress,
                        customer.OpenBalance.ToString() + "€",
                        customer.LastChange.ToString() };
                        DataGridView_CustomerList.Rows.Add(columnData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripComboBox_SetLanguage.Items.Add("English");
            toolStripComboBox_SetLanguage.Items.Add("German");
            toolStripComboBox_SetLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            Properties.Settings.Default.Reload();
            toolStripComboBox_SetLanguage.SelectedIndex = Properties.Settings.Default.Language;
        }

        private void toolStripComboBox_SetLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox_SetLanguage.SelectedIndex == 0) // English
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en");
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            }
            else if (toolStripComboBox_SetLanguage.SelectedIndex == 1) // German
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de");
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de");
            }
            Properties.Settings.Default.Language = toolStripComboBox_SetLanguage.SelectedIndex;
            Properties.Settings.Default.Save();
            // Change language of the whole programm
            this.Text = GlobalStrings.FormCustomerDatabase;
            Lbl_NameDatabase.Text = GlobalStrings.Lbl_DatabaseName_Default;
            Lbl_Database.Text = GlobalStrings.Lbl_Database;
            databaseToolStripMenuItem.Text = GlobalStrings.ToolStripeMenüDatabase;
            addDatabaseToolStripMenuItem.Text = GlobalStrings.ToolStripMenuItemaAddDatabase;
            openDatabaseToolStripMenuItem.Text = GlobalStrings.ToolStripMenuItemaOpenDatabase;
            addCustomerToolStripMenuItem1.Text = GlobalStrings.ToolStripMenuItemaAddCustomer;
            showCustomerListToolStripMenuItem.Text = GlobalStrings.ToolStripMenuItemShowCustomerList;
            hideCustomerListToolStripMenuItem1.Text = GlobalStrings.ToolStripMenuItemHideCustomerList;
            paymentsToolStripMenuItem.Text = GlobalStrings.ToolStripMenuItemPayments;
            languageToolStripMenuItem.Text = GlobalStrings.ToolStripLanguage;
            this.Column_FirstName.HeaderText = GlobalStrings.DataGridView_Column_FirstNameText;
            this.Column_LastName.HeaderText = GlobalStrings.DataGridView_Column_LastNameText;
            this.Column_EmailAddress.HeaderText = GlobalStrings.DataGridView_Column_EmailText;
            this.Column_OpenBalance.HeaderText = GlobalStrings.DataGridView_Column_OpenBalanceText;
            this.Column_LastChange.HeaderText = GlobalStrings.DataGridView_Column_LastChangeText;
            //Name der gewählten Datenbank (Label über dem Datagridview) gehört noch geändert.

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // safe the last user settings
            Properties.Settings.Default.Save();
        }
    }
}
