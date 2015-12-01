﻿using System;
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

        public MakeAPayment(AggActiveAccount prof)
        {
            InitializeComponent();
            profile = prof;
            CopyObject2Form(profile);
            this.Show();
        }

        public void CopyObject2Form(AggActiveAccount profile)
        {
            accBalBox2.Text = "$" + profile.Balance.ToString();
        }

        private void submitButt_Click(object sender, EventArgs e)
        {
            profile.Balance -= Convert.ToDouble(paymentUpDown.Text);
            //string sqlQuery = "UPDATE Account.Balance("profile.Balance") WHERE ";

            CopyObject2Form(profile);
            
        }

        private void makeAPaymentTrans(double p)
        {
            //balance += p;
            if (balance - p >= 0)
            {
                balance -= p;
            }
            else
            {
                balance -= p;
            }
        }

        //will return true if user enters a valid number

        private void backToHome_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberHome form = new MemberHome(profile);
        }
    }
}
