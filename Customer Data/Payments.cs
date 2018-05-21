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
    public partial class Payments : Form
    {
        private ListCustomer CustomerList = new ListCustomer();
        private Customer Customer = new Customer();

        public Payments(ListCustomer customerlist, int indexSelectedCustomer)
        {
            this.CustomerList = customerlist;
            this.Customer = CustomerList.List[indexSelectedCustomer];
            InitializeComponent();
        }

        // Pay in
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Customer.PayIn(Convert.ToInt32(Txb_Amount.Text));
                // show new amount of the account
                this.Txb_MoneyAccount.Text = Customer.OpenBalance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_PayOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Customer.PayOut(Convert.ToInt32(Txb_Amount.Text));
                // show new amount of the account
                this.Txb_MoneyAccount.Text = Customer.OpenBalance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.CustomerList.UpdateDatabase();
                DialogResult = DialogResult.OK;
                MessageBox.Show(GlobalStrings.ChangeCustomerSuccessfully);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
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

        private void Txb_Amount_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Double.TryParse(Txb_Amount.Text, out double money))
                {
                    this.EP_ErrorMessage.SetError(Txb_Amount, GlobalStrings.FailureTxbAmount);
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

        private void Payments_Load(object sender, EventArgs e)
        {
            this.Text = GlobalStrings.FormPayments;
            Lbl_Amount.Text = GlobalStrings.LblAmount;
            Btn_Quit.Text = GlobalStrings.Btn_QuitText;
            Btn_PayIn.Text = GlobalStrings.BtnPayIn;
            Btn_PayOut.Text = GlobalStrings.BtnPayOut;
            this.Text = GlobalStrings.FormAddCustomer;
            label1.Text = GlobalStrings.LblFirstName;
            label2.Text = GlobalStrings.LblLastName;
            label3.Text = GlobalStrings.LblEmail;
            label4.Text = GlobalStrings.LblMoney;
            Btn_Quit.Text = GlobalStrings.Btn_QuitText;
            Btn_Save.Text = GlobalStrings.Btn_SaveChanges;
            this.Txb_FirstName.Text = Customer.FirstName;
            this.Txb_LastName.Text = Customer.LastName;
            this.Txb_EmailAddress.Text = Customer.EmailAddress;
            this.Txb_MoneyAccount.Text = Customer.OpenBalance.ToString();
        }

    }
}
