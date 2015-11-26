using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MIS220GroupProject
{
    class AggActiveAccount :Account
    {
        private int id;
        private string fName;
        private string lName;
        private string address1;
        private string address2;
        private string phone;
        private string city;
        private string state;
        private int zip;
        private DateTime dateOfBirth;
        private string username;
        private int memberID;
        private string password;
        private bool isAdmin;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
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

        public int CreateAggActiveAccount(string fName, string lName, string address1, string address2, string phone, string city, string state, Int32 zip, string dateOfBirth)
        {
            //SQL Statement for creating new member
            string sqlIns = "INSERT INTO Member(FirstName, LastName, DOB, Address1, Address2, City, State, Zip, Phone)" +
                            "VALUES(@firstName, @lastName, @DOB, @address1, @address2, @city, @state, @zip, @phone)" +
                //SQL returns auto-implemented memID used to create corresponding login
                            "select SCOPE_IDENTITY();";


            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id = uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);


            try
            {
                //non-query
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

                cmdIns.Parameters.Clear();
                cmdIns.Dispose();
                cmdIns = null;

                dbCon.Open();
                //expected result from scope_identity query
                Int32 scopeID = Convert.ToInt32(cmdIns.ExecuteScalar());
                return scopeID;


            }

            //catch(Exception ex)//need to write exceptions
            finally
            {
                dbCon.Close();
            }
        }

        public DataSet CreateAggDataTable(string userName, string password)
        {
            //SQL Statement for creating new member
            string sqlQuery = "declare @userName varchar(50), @password varchar(50)" +
            " set @userName = '" + userName + "' set @password = '" + password + "'" +
            "SELECT * FROM Login l, Member m where l.Username = @userName and l.Password = @password and l.MemberID = m.MemID;";

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                DataSet memberDataSet = new DataSet();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, dbCon))
                {
                    cmd.Connection.Open();
                    DataTable memberTable = new DataTable();
                    memberTable.Load(cmd.ExecuteReader());
                    //string tableName = "MemberInfoTable";
                    memberDataSet.Tables.Add(memberTable);
                }
                return memberDataSet;
            }
            finally
            {
                dbCon.Close();
            }

        }
    
    }
}
