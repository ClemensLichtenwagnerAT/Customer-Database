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
    public partial class EditCustomer : Form
    {
        private ListCustomer CustomerList = new ListCustomer();
        private Customer Customer = new Customer();
        private int IndexSelectedCustomer;

        public EditCustomer(ListCustomer customerList, int indexSelectedCustomer)
        {
            this.CustomerList = customerList;
            this.IndexSelectedCustomer = indexSelectedCustomer;
            this.Customer = CustomerList.List[IndexSelectedCustomer];
            InitializeComponent();
        }

        private void Btn_SaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Customer.LastName != this.Txb_LastName.Text || Customer.EmailAddress != this.Txb_EmailAddress.Text)
                {
                    if (CustomerList.CheckEmail(this.Txb_EmailAddress.Text))
                    {
                        Customer.ChangeLastName(this.Txb_LastName.Text);
                        Customer.ChangeEmailAddress(this.Txb_EmailAddress.Text);
                        CustomerList.UpdateDatabase();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show(GlobalStrings.ChangeCustomerSuccessfully);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(GlobalStrings.FailureChangeEmail);
                    }
                }
                else
                {
                    MessageBox.Show(GlobalStrings.CustomerDataNoChange);
                    this.Close();
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

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            this.Text = GlobalStrings.FormEditCustomer;
            label1.Text = GlobalStrings.LblFirstName;
            label2.Text = GlobalStrings.LblLastName;
            label3.Text = GlobalStrings.LblEmail;
            label4.Text = GlobalStrings.LblMoney;
            Btn_Close.Text = GlobalStrings.Btn_QuitText;
            Btn_SaveCustomer.Text = GlobalStrings.Btn_SaveChanges;
            this.Txb_FirstName.Text = Customer.FirstName;
            this.Txb_LastName.Text = Customer.LastName;
            this.Txb_EmailAddress.Text = Customer.EmailAddress;
            this.Txb_MoneyAccount.Text = Customer.OpenBalance.ToString();
        }

        #region Validating
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        
    }
}
