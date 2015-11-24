using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace MIS220GroupProject
{
    public static class MemberDL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Data Source = mis220.eil - server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide"].ConnectionString;



        //-----------Methods-----------


        public static string ConnectionString
        {
            get {  return MemberDL.connectionString; }
            set { MemberDL.connectionString = value; }
        }

        public static void CreateAccount(string fName, string lName, string address1, string address2, string phone, string city, string state, Int32 zip, string dateOfBirth)
        {
            string sqlIns = "INSERT INTO Member(FirstName, LastName, DOB, Address1, Address2, City, State, Zip, Phone) VALUES(@firstName, @lastName, @DOB, @address1, @address2, @city, @state, @zip, @phone)";
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);


            try
            {
                SqlCommand cmdIns = new SqlCommand(sqlIns, dbCon);
                cmdIns.Parameters.AddWithValue("@firstName", fName);
                cmdIns.Parameters.AddWithValue("@lastName", lName);
                cmdIns.Parameters.AddWithValue("@DOB", dateOfBirth);
                cmdIns.Parameters.AddWithValue("@address1", address1);
                cmdIns.Parameters.AddWithValue("@address2", address2);
                cmdIns.Parameters.AddWithValue("@city", city);
                cmdIns.Parameters.AddWithValue("@state", state);
                cmdIns.Parameters.AddWithValue("@zip", zip);
                cmdIns.Parameters.AddWithValue("@phone", phone);

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
