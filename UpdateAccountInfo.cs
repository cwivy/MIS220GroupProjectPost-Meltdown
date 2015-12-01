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
    public partial class UpdateAccountInfo : Form
    {
        AggActiveAccount profile;
        public UpdateAccountInfo(AggActiveAccount prof)
        {
            InitializeComponent();
            profile = prof;
            CopyObject2Form(profile);
            this.Show();
        }

        private void UpdateAccountInfo_Load(object sender, EventArgs e)
        {

        }

        public void CopyObject2Form(AggActiveAccount prof)
        {
            firstName_TXT.Text = prof.FName;
            lastName_TXT.Text = prof.LName;
            address1_TXT.Text = prof.Address1;
            address2_TXT.Text = prof.Address2;
            city_TXT.Text = prof.City;
            state_TXT.Text = prof.State;
            zip_TXT.Text = prof.Zip.ToString();
            phone_TXT.Text = prof.Phone;
            cardNum_TXT.Text = prof.CardNum.ToString();            
            if (prof.PaymentType == 1)
                cardTypeDropBox.Text = "Credit";
            if (prof.PaymentType == 0)
                cardTypeDropBox.Text = "Debit";                       
            passwordBox.Text = prof.Password;
        }

        public AggActiveAccount CopyForm2Object(AggActiveAccount profile)
        {
            profile.FName = firstName_TXT.Text;
            profile.LName = lastName_TXT.Text;
            profile.Address1 = address1_TXT.Text;
            profile.Address2 = address2_TXT.Text;
            profile.City = city_TXT.Text;
            profile.State = state_TXT.Text;
            profile.Zip = Convert.ToInt32(zip_TXT.Text);
            profile.Phone = phone_TXT.Text;            
            profile.CardNum = Convert.ToInt64(cardNum_TXT.Text);
            if (cardTypeDropBox.Text == "Credit")
                profile.PaymentType = 1;
            if (cardTypeDropBox.Text == "Debit")
                profile.PaymentType = 0;
            return profile;
        }

        private void saveAcctInfo_BTN_Click(object sender, EventArgs e)
        {
            profile = CopyForm2Object(profile);
            //SQL Stuff to update Account            
            UpdateProfileInfo(cardNum_TXT.Text, profile.PaymentType, firstName_TXT.Text, lastName_TXT.Text, address1_TXT.Text, address2_TXT.Text, city_TXT.Text, state_TXT.Text, Convert.ToInt32(cardNum_TXT.Text), phone_TXT.Text, passwordBox.Text, profile.AccId, profile.MemberID, profile.Username);
            
            this.Hide();
            AccountInfo form = new AccountInfo(profile);
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AccountInfo form = new AccountInfo(profile);
            this.Hide();
            form.Show();
        }

        public static void UpdateProfileInfo(string cardNumber, int paymentType, string fName, string lName, string address1, string address2, string city, string state, Int32 zip, string phone, string password, int accountID, int memberID, string userName)
        {
            //SQL Statement for updating member info
            string sqlProfileCreate =
                //updating account with info provided on form
                "update Account " +
                "set CardNumber = @cardNumber, PaymentType = @paymentType " +
                "where AccountID = '" + accountID + "' " +
                //updating member info
                "update Member " +
                "set FirstName = @firstName, LastName = @lastName, Address1 = @address1, Address2 = @address2, City = @city, State = @state, Zip = @zip, Phone = @phone " +
                "where MemID = '" + memberID + "' " +
                //creates a login with supplied username and password. Admin status is set to 'null' as default
                "update Login " +
                "set Password = @password " +
                "where Username = '" + userName + "'; ";

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id = uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                //non-query
                SqlCommand cmdIns = new SqlCommand(sqlProfileCreate, dbCon);
                //update account
                cmdIns.Parameters.AddWithValue("@cardNumber", cardNumber);
                cmdIns.Parameters.AddWithValue("@paymentType", paymentType);
                //update member
                cmdIns.Parameters.AddWithValue("@firstName", fName);
                cmdIns.Parameters.AddWithValue("@lastName", lName);                
                cmdIns.Parameters.AddWithValue("@address1", address1);
                cmdIns.Parameters.AddWithValue("@address2", address2);
                cmdIns.Parameters.AddWithValue("@city", city);
                cmdIns.Parameters.AddWithValue("@state", state);
                cmdIns.Parameters.AddWithValue("@zip", zip);
                cmdIns.Parameters.AddWithValue("@phone", phone);
                //update login
                cmdIns.Parameters.AddWithValue("@password", password);

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
                
            }
        }
    }
}
