using System;
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
    public partial class Checkout : Form
    {
        AggActiveAccount profile;
        string movie;
        double price;
        int rentLength;
        public Checkout(AggActiveAccount prof, string movieSelect, double moviePrice, int daysForRent)
        {
            InitializeComponent();
            profile = prof;
            movie = movieSelect;
            price = moviePrice;
            rentLength = daysForRent;
            CopyObject2Form(movieSelect, profile, moviePrice, rentLength);
        }

        public void CopyObject2Form(string movieSelect, AggActiveAccount prof, double moviePrice, int rentLength)
        {
            movieTitle_TXT.Text = movieSelect;
            currentBal_TXT.Text = prof.Balance.ToString();
            afterBal_TXT.Text = Convert.ToString((prof.Balance) - (moviePrice));
            dueDateBox.Text = Convert.ToString(DateTime.Now.AddDays(rentLength));
        }

        private void checkoutCancel_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieList movieListForm = new MovieList(profile);
            movieListForm.Show();            
        }
                
        private void checkoutConfirm_BTN_Click(object sender, EventArgs e)
        {
            RunConfirmOrderSqlStatement(profile, movie, price);
        }

        private void RunConfirmOrderSqlStatement(AggActiveAccount prof, string movieSelect, double moviePrice)
        {
            //SQL Statement for creating new member
            string sqlProfileCreate =
                //updating active user account balance by subtracting the movie price (math is already done in copyObjectToForm method)                
                "update Account " +
                "set Balance = '" + Convert.ToDouble(afterBal_TXT.Text) + "' " +
                "where AccountID = '" + prof.AccId + "' " +
                //creating a new transaction
                "declare @movieID int " +
                "set  @movieID = (select movieID from Movie where Title = '" + movieSelect + "') " +
                "insert into Transactions(AccountID, MovieID, RewardID, RentDate, DueDate, Total) " +                
                "values('"+ prof.AccId + "', @movieID, null, GETDATE(), '"+dueDateBox.Text+"', '"+moviePrice+"')";


            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id = uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                //non-query
                SqlCommand cmdIns = new SqlCommand(sqlProfileCreate, dbCon);
                //updating account
                //cmdIns.Parameters.AddWithValue("@accountID", prof.AccId);
                //cmdIns.Parameters.AddWithValue("@newBalance", Convert.ToDouble(afterBal_TXT.Text));
                //new transaction                
                //cmdIns.Parameters.AddWithValue("@title", movieSelect);
                //cmdIns.Parameters.AddWithValue("@dueDate", dueDateBox.Text);
                //cmdIns.Parameters.AddWithValue("@total", moviePrice);

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
                MessageBox.Show("Your order has been confirmed! Thank you for your business!");                
                this.Hide();
                MovieList movieListForm = new MovieList(profile);
                movieListForm.Show();
            }
        }
    }
}
