using System;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try { 
           
                float BillAmount = float.Parse(txtBillAmount.Text);
                float TipPercent = float.Parse(txtTipPercent.Text) / 100;
                int NumberOfPerson = Convert.ToInt32(txtNumberOfPerson.Text);

                //Validate Input
                if (BillAmount !=null && TipPercent != null && NumberOfPerson!=null)
                {
                    //Calculate each persons tip
                    float tip = ((BillAmount * TipPercent) / NumberOfPerson);

                    //Round to two decimal places
                    tip = (float)Math.Round(tip * 100f) / 100f;

                    //Calculate each person bill after adding tip
                    float NewBill = ((BillAmount * TipPercent) / NumberOfPerson) + BillAmount / NumberOfPerson;

                     //Round to two decimal places
                     NewBill = (float)Math.Round(NewBill * 100f) / 100f;

                    //Getting the value 
                    txtTipPerPerson.Text = tip.ToString("F2"); //"F2"Allows to have two digits after decimal
                    txtTotalPerPerson.Text = NewBill.ToString("F2");
                }
                else
                {
                    throw new FormatException(); //throw exception
                }
                }

                 catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }

        }

        private void txtBillAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only number in the text field
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
            
        }

        private void txtTipPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only number in the text field
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNumberOfPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only number in the text field
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
            }
        }
    }
}
