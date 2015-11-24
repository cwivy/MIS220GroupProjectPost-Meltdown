using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MIS220GroupProject
{
    public class Login
    {        
        private string username;
        private int memberID;
        private string password;
        private bool isAdmin;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        //Methods-------------------------------------------------------------------------------

        public void CreateLogin(string userName, string password, int memID)
        {
            //SQL Statement to create new login connecting to new member creation
            string sqlIns = "insert into Login(username, MemberID, Password, IsAdmin) values (@username, @memberID, @password, null);";

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                SqlCommand cmdIns = new SqlCommand(sqlIns, dbCon);
                cmdIns.Parameters.AddWithValue("@username", userName);
                cmdIns.Parameters.AddWithValue("@password", password);
                cmdIns.Parameters.AddWithValue("@memberID", memID);
                
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
        }//End createLogin

        
    }
}
