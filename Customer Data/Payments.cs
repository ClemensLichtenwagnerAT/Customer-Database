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
        private double _Amount;

        public Payments()
        {
            InitializeComponent();
        }

        public double Amount
        {
            get
            {
                return this._Amount;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this._Amount = Convert.ToInt32(Txb_Amount.Text);
                this.Close();
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
                this._Amount = Convert.ToInt32(Txb_Amount.Text);
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
        }
    }
}
