﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


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
            accBalBox2.Text = profile.Balance.ToString();
            cardNumberBox.Text = profile.CardNum.ToString();
        }

        private void submitButt_Click(object sender, EventArgs e)
        {
            bool procede = false;//used to break the loop
            do 
            {
                if(paymentUpDown.Value < 0)
                {
                    MessageBox.Show("Please enter a positive payment amount");
                    paymentUpDown.Value = 0;
                    procede = false;
                }
                else if(profile.Balance - Convert.ToDouble(paymentUpDown.Value) < 0)
                {
                    MessageBox.Show("This amount will give you a negative balance. Did you mean to enter this amount?");
                    paymentUpDown.Value = 0;
                    procede = false;
                }
                else
                { procede = true; } //if payment is positive and they arent paying more than amount owed this can be submitted to SQL
            } while (procede == false);
            //SQL Statement for processing an account payment
            string sqlProfileCreate =
                "update Account " +
                "set Balance = (Balance - @paymentAmount) " +
                "where AccountID = '"+ profile.AccId +"';";                            
               
            
            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id = uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                //non-query
                SqlCommand cmdIns = new SqlCommand(sqlProfileCreate, dbCon);

                cmdIns.Parameters.AddWithValue("@paymentAmount", paymentUpDown.Value);

                dbCon.Open();
                cmdIns.ExecuteNonQuery();
                cmdIns.Parameters.Clear();
                cmdIns.Dispose();
                cmdIns = null;
            }

            //catch(Exception ex)//need to write exceptions
            finally
            {
                dbCon.Close();
                MessageBox.Show("Your payment has been confirmed! Thank you for your business!");
                this.Hide();
                MemberHome form = new MemberHome(profile);
            }            
        }

        private void errorMessage()
        {
            MessageBox.Show("Invalid entry, please enter a valid ammount!");
        }        
        
        private void backToHome_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberHome form = new MemberHome(profile);
        }
    }
}
