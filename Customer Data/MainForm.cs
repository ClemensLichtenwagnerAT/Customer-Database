using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Customer_Data
{
    public partial class MainForm : Form
    {
        private List<Customer> CustomerList = new List<Customer>(); // only for testing

        public MainForm()
        {
            InitializeComponent();
            DataGridView_CustomerList.Visible = false;
            Lbl_Customers.Visible = false;

        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments dialog = new Payments();
            dialog.ShowDialog();
        }

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewCustomer dialog = new AddNewCustomer();
                dialog.ShowDialog();
                if (dialog.GetNewCustomer != null)
                {
                    CustomerList.Add(dialog.GetNewCustomer);//nur zum testen...später anbindung an Database von Tobi
                    // enter the data of the new user in the DataGridView
                    string[] columnData = new string[] { dialog.GetNewCustomer.FirstName, dialog.GetNewCustomer.LastName, dialog.GetNewCustomer.EmailAddress, dialog.GetNewCustomer.OpenBalance.ToString() + "€", dialog.GetNewCustomer.LastChange.ToString() };
                    DataGridView_CustomerList.Rows.Add(columnData);
                }
                else
                {
                    MessageBox.Show($"Invalid input!");
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
            Lbl_Customers.Visible = true;
        }

        private void hideCustomerListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridView_CustomerList.Visible = false;
            Lbl_Customers.Visible = false;
        }

        private void addDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddDatabase dialog = new AddDatabase();
                dialog.ShowDialog();
                // Anbindung an Tobis Datenbank
                //CreateNewDatabase(dialog.NameDatabase, dialog.Password);
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
                OpenDatabase dialog = new OpenDatabase();
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Open database aborted1");
                }
                else if (dialog.DialogResult == DialogResult.OK)
                {
                    string nameDatabaseToOpen = dialog.GetDataBaseName;
                    string password = dialog.GetPasswordforDatabase;
                }
                // Tobi - Datenbank Zugriff
                // Tobi braucht nur den Filenamen und das Password der Datenbank
                // Liste mit Customer aus Datenbank laden und in DataGridView anzeigen
                //// String Array mit CustomerDaten
                ////string[] columnData = new string[] {dialog.GetNewCustomer.FirstName, dialog.GetNewCustomer.LastName, dialog.GetNewCustomer.EmailAddress, dialog.GetNewCustomer.OpenBalance.ToString() + "€", dialog.GetNewCustomer.LastChange.ToString() };
                ////DataGridView_CustomerList.Rows.Add(columnData);
                //DataGridView_CustomerList.Visible = true;
                //Lbl_Customers.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the database! " + ex.Message);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

}
