using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MIS220GroupProject
{
    class AggActiveAccount 
    {
        //member variables
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
        //account variables
        private int accId;
        private int cardNum;
        private double balance;
        private List<int> rentalsHeld;
        private string memStatus;
        private int paymentType;
        //login variables
        private string username;
        private int memberID;
        private string password;
        private bool isAdmin;
        

        //member get sets
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
        //account get sets
        public int AccId
        {
            get { return accId; }
            set { accId = value; }
        }

        public int CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<int> RentalsHeld
        {
            get { return rentalsHeld; }
            set { rentalsHeld = value; }
        }

        public string MemStatus
        {
            get { return memStatus; }
            set { memStatus = value; }
        }

        public int PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        //login get sets
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

        public void CreateNewProfile(string cardNumber, string paymentType, string fName, string lName, string dateOfBirth, string address1, string address2, string city, string state, Int32 zip, string phone, string userName, string password)
        {           
            //SQL Statement for creating new member
            string sqlProfileCreate =
                //creates a default account and gathers the auto-incremented accID to link the account and member tables
                "declare @accID int, @memStatus varchar(20), @balance decimal(10,2), @cardNumber bigint, @paymentType bit" +
                "insert into Account(MemStatus, Balance, CardNumber, PaymentType)" +
                "values(@memStatus, @balance, @cardNumber, @paymentType)" +
                "set @accID = SCOPE_IDENTITY()" +
                //creates a member with the supplied information and gathers the auto-incremented memID to link the member and login tables
                "declare @memID int, @firstName varchar(50), @lastName varchar(50), @DOB datetime, @address1 varchar(50), @address2 varchar(50), @city varchar(50), @state varchar(20), @zip int, @phone varchar(20)" +
                "insert into Member(AccountID, FirstName, LastName, DOB, Address1, Address2, City, State, Zip, Phone)" +
                "values(@accID, @firstName, @lastName, @DOB, @address1, @address2, @city, @state, @zip, @phone)" +
                "set @memID = SCOPE_IDENTITY()" +
                //creates a login with supplied username and password. Admin status is set to 'null' as default
                "declare @userName varchar(50), @password varchar(50)" +
                "insert into Login(Username, MemberID, Password, IsAdmin)" +
                "values(@userName, @memID, @password, null);";

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id = uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                //non-query
                SqlCommand cmdIns = new SqlCommand(sqlProfileCreate, dbCon);
                //insert into account
                        //memStatus and balance are set to default values. If need to be set uncomment and set value of variable
                        //cmdIns.Parameters.AddWithValue("@memStatus", memStatus);
                        //cmdIns.Parameters.AddWithValue("@balance", balance);
                cmdIns.Parameters.AddWithValue("@cardNumber", cardNumber);
                cmdIns.Parameters.AddWithValue("@paymentType", paymentType);
                //insert into member
                cmdIns.Parameters.AddWithValue("@firstName", fName);
                cmdIns.Parameters.AddWithValue("@lastName", lName);
                cmdIns.Parameters.AddWithValue("@DOB", dateOfBirth);
                cmdIns.Parameters.AddWithValue("@address1", address1);
                cmdIns.Parameters.AddWithValue("@address2", address2);
                cmdIns.Parameters.AddWithValue("@city", city);
                cmdIns.Parameters.AddWithValue("@state", state);
                cmdIns.Parameters.AddWithValue("@zip", zip);
                cmdIns.Parameters.AddWithValue("@phone", phone);
                //insert into login- remaining values are auto generated/ set to default values 
                cmdIns.Parameters.AddWithValue("@userName", userName);
                cmdIns.Parameters.AddWithValue("@password", password);

                cmdIns.Parameters.Clear();
                cmdIns.Dispose();
                cmdIns = null;

                dbCon.Open();
                cmdIns.ExecuteNonQuery();

            }

            //catch(Exception ex)//need to write exceptions
            finally
            {
                dbCon.Close();
            }
        }

        public DataSet CreateAggDataTable(string userName, string password)
        {//This method pulls all relevant information for the user that logs in

            //creating the temp variables to pass the supplied username and password
            string sqlQuery = "declare @userName varchar(50), @password varchar(50)" +
            //passing username and password from for to SQL to find correct member
            " set @userName = '" + userName + "' set @password = '" + password + "'" +
            //selecting account, login, and member information corresponding to the login credentials
            "SELECT * FROM Login l, Member m, Account a where l.Username = @userName and l.Password = @password and l.MemberID = m.MemID and m.AccountID = a.AccountID;";
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
