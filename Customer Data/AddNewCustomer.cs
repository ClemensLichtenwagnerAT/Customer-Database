using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibary;

namespace Customer_Data
{
    public partial class AddNewCustomer : Form
    {

        private ListCustomer ListCustomer = new ListCustomer();
        private Customer NewCustomer;

        public AddNewCustomer(ListCustomer customerlist)
        {
            InitializeComponent();
            this.ListCustomer = customerlist;
        }

        public Customer GetNewCustomer
        {
            get
            {
                return this.NewCustomer;
            }
        }

        private void Btn_SaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                NewCustomer = new Customer(Txb_FirstName.Text,
                    Txb_LastName.Text,
                    Txb_EmailAddress.Text,
                    Convert.ToInt32(Txb_MoneyAccount.Text),
                    DateTime.Now);
                if (ListCustomer.AddCustomer(NewCustomer) && ListCustomer.UpdateDatabase())
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show(GlobalStrings.AddCustomerSuccessful);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(GlobalStrings.FailureAddCustomer_2);
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
                this.EP_ErrorMessage.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txb_FirstName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string firstName = Txb_FirstName.Text;
                if (firstName == string.Empty)
                {
                    this.EP_ErrorMessage.SetError(Txb_FirstName, GlobalStrings.FailureInputTxbNames_Empty);
                    e.Cancel = true;
                }
                else if (!Char.IsUpper(firstName[0]))
                {
                    EP_ErrorMessage.SetError(Txb_FirstName, GlobalStrings.FailureInputTxbNames_InvalidFirstLetter);
                    e.Cancel = true;
                }
                else
                {
                    this.EP_ErrorMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txb_EmailAddress_Validating(object sender, CancelEventArgs e)
        {
            string emailAddress = Txb_EmailAddress.Text;
            bool isEmailcorrect = false;
            int counter = 0;
            int counterPoint = 0;
            try
            {
                // E-mail address must have at least one . after the @ and must contain exactly one @
                for (int i = 0; i < emailAddress.Length; i++)
                {
                    if (emailAddress[i] == '@')
                    {
                        counter++; // counter for the @
                        for (int j = i; j < emailAddress.Length; j++)
                        {
                            if (emailAddress[j] == '.')
                            {
                                counterPoint++; // counter for the points
                            }
                        }
                        if (counter == 1 && counterPoint != 0)
                        {
                            isEmailcorrect = true;
                        }
                    }
                }// end for-loop
                int counterCharactersAfterPoint = 0;
                for (int i = emailAddress.Length - 1; i >= 0; i--)
                {
                    if (emailAddress[i] == '.' && counterCharactersAfterPoint >= 2 && counterCharactersAfterPoint <= 4)
                    {
                        isEmailcorrect = true;
                        break;
                    }
                    else if (Char.IsLetter(emailAddress[i]))
                    {
                        counterCharactersAfterPoint++;
                    }
                    else
                    {
                        isEmailcorrect = false;
                        break;
                    }
                }
                if (!isEmailcorrect)
                {
                    EP_ErrorMessage.SetError(Txb_EmailAddress, GlobalStrings.FailureInputTxbEmail);
                    e.Cancel = true;
                }
                else
                {
                    EP_ErrorMessage.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txb_LastName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string lastName = Txb_LastName.Text;
                if (lastName == string.Empty)
                {
                    this.EP_ErrorMessage.SetError(Txb_LastName, GlobalStrings.FailureInputTxbNames_Empty);
                    e.Cancel = true;
                }
                else if (!Char.IsUpper(lastName[0]))
                {
                    EP_ErrorMessage.SetError(Txb_LastName, GlobalStrings.FailureInputTxbNames_InvalidFirstLetter);
                    e.Cancel = true;
                }
                else
                {
                    this.EP_ErrorMessage.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txb_MoneyAccount_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Double.TryParse(Txb_MoneyAccount.Text, out double money))
                {
                    this.EP_ErrorMessage.SetError(Txb_MoneyAccount, GlobalStrings.FailureTxbAmount);
                    e.Cancel = true;
                }
                else
                {
                    EP_ErrorMessage.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewCustomer_Load(object sender, EventArgs e)
        {
            this.Text = GlobalStrings.FormAddCustomer;
            label1.Text = GlobalStrings.LblFirstName;
            label2.Text = GlobalStrings.LblLastName;
            label3.Text = GlobalStrings.LblEmail;
            label4.Text = GlobalStrings.LblMoney;
            Btn_Close.Text = GlobalStrings.Btn_QuitText;
            Btn_SaveCustomer.Text = GlobalStrings.BtnSave;
        }
    }
}
