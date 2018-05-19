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
            catch(Exception)
            {

            }
        }

        private void Btn_PayOut_Click(object sender, EventArgs e)
        {
            try
            {
                this._Amount = Convert.ToInt32(Txb_Amount.Text);
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void Txb_Amount_Validating(object sender, CancelEventArgs e)
        {

        }

    }
}
