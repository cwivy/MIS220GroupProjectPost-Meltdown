using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS220GroupProject
{
    public partial class MakeAPayment : Form
    {
        AggActiveAccount profile;
        private static double balance = 0;
        private static int totalMakePayment = 0;
        private static double totalMakePaymentAmt = 0;
        private static int totalAddBalance = 0;
        private static double totalAddBalanceAmt = 0;

        public MakeAPayment(AggActiveAccount prof)
        {
            InitializeComponent();
            profile = prof;
            this.Show();
        }

        private void clearButt_Click(object sender, EventArgs e)
        {
            makeAPaymentBox.Clear();
        }

        private void submitButt_Click(object sender, EventArgs e)
        {
            char transaction = ' ';
            //check to see which radio button is selected
            if (radioPaymentButton.Checked)
            {
                transaction = 'p';//make a payment from balance
            }

            switch (transaction)
            {
                case 'p':
                    if (validateTextBox())
                    {
                        double payment = Convert.ToDouble(makeAPaymentBox.Text);
                        makeAPaymentTrans(payment);
                        displayBal();
                    }
                    else
                    {
                        errorMessage();
                    }
                    break;
                default:
                    MessageBox.Show("Select A Transaction");
                    break;
            }
        }

        private void errorMessage()
        {
            MessageBox.Show("Invalid entry, please enter a valid ammount!");
        }

        //display account balance
        private void displayBal()
        {
            accBalBox2.Text = "$" + balance.ToString();
        }

        private void makeAPaymentTrans(double p)
        {
            balance += p;
            //if (balance - p >= 0)
            //{
            //    balance -= p;
            //}
            //else
            //{
            //    MessageBox.Show("Transaction can't be completed because the balance would be less than zero!");
            //}
        }

        //will return true if user enters a valid number
        private bool validateTextBox()
        {
            double value;
            return double.TryParse(makeAPaymentBox.Text, out value);

        }

        private void backToHome_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberHome form = new MemberHome(profile);
        }
    }
}
