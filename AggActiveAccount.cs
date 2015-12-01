using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MIS220GroupProject
{
    public class AggActiveAccount 
    {
        //member variables
        private int memId;
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
        private long cardNum;
        private double balance;
        private List<int> rentalsHeld;
        private string memStatus;
        private int paymentType;
        //login variables
        private string username;
        public static int memberID;
        private string password;
        private bool isAdmin;
        

        //member get sets
        public int MemId
        {
            get { return memId; }
            set { memId = value; }
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

        public long CardNum
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

        public static void CreateNewProfile(string cardNumber, string paymentType, string fName, string lName, DateTime dateOfBirth, string address1, string address2, string city, string state, Int32 zip, string phone, string userName, string password)
        {           
            //SQL Statement for creating new member
            string sqlProfileCreate =
                //creates a default account and gathers the auto-incremented accID to link the account and member tables
                "insert into Account(MemStatus, Balance, CardNumber, PaymentType)" +
                "values('Bronze', '0.00', @cardNumber, @paymentType)" +
                //creates a member with the supplied information and gathers the auto-incremented memID to link the member and login tables
                "insert into Member(AccountID, FirstName, LastName, DOB, Address1, Address2, City, State, Zip, Phone)" +
                "values(SCOPE_IDENTITY(), @firstName, @lastName, @DOB, @address1, @address2, @city, @state, @zip, @phone)" +
                //creates a login with supplied username and password. Admin status is set to 'null' as default
                "insert into Login(Username, MemberID, Password, IsAdmin)" +
                "values(@userName, SCOPE_IDENTITY(), @password, null);";

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id = uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                //non-query
                SqlCommand cmdIns = new SqlCommand(sqlProfileCreate, dbCon);
                //insert into account
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

        public static DataTable CreateAggDataTable(string userName, string password)
        {//This method pulls all relevant information for the user that logs in

            //creating the temp variables to pass the supplied username and password
            string sqlQuery = "declare @userName varchar(50), @password varchar(50)" +
            //passing username and password from for to SQL to find correct member
            " set @userName = '" + userName + "' set @password = '" + password + "'" +
            //selecting account, login, and member information corresponding to the login credentials
            "SELECT * FROM Login l, Member m, Account a WHERE l.Username = @userName and l.Password = @password and l.MemberID = m.MemID and m.AccountID = a.AccountID;";

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                DataTable memberTable = new DataTable();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, dbCon))
                {
                    cmd.Connection.Open();
                    memberTable.Load(cmd.ExecuteReader());
                }
                return memberTable;
            }
            finally
            {
                dbCon.Close();
            }
        }

        public void PopulateProfile(DataRow data)
        {
            //Populating Member members
            this.MemId = Convert.ToInt32(Convert.ToString(data["MemID"]));
            this.FName = Convert.ToString(data["FirstName"]);
            this.LName = Convert.ToString(data["LastName"]);
            this.Address1 = Convert.ToString(data["Address1"]);
            this.Address2 = Convert.ToString(data["Address2"]);
            this.Phone = Convert.ToString(data["Phone"]);
            this.City = Convert.ToString(data["City"]);
            this.State = Convert.ToString(data["State"]);
            this.zip = Convert.ToInt32(Convert.ToString(data["Zip"]));
            this.dateOfBirth = Convert.ToDateTime(data["DOB"]);

            //Populating Account members
            this.AccId = Convert.ToInt32(Convert.ToString(data["AccountID"]));
            this.MemStatus = Convert.ToString(data["MemStatus"]);
            this.Balance = Convert.ToDouble(Convert.ToString(data["Balance"]));
            this.CardNum = Convert.ToInt64(Convert.ToString(data["CardNumber"]));
            this.PaymentType = Convert.ToInt32(data["PaymentType"]);

            //Populating Login Members
            this.Username = Convert.ToString(data["Username"]);
            this.MemberID = Convert.ToInt32(Convert.ToString(data["MemberID"]));
            this.Password = Convert.ToString(data["Password"]);
            string buff = Convert.ToString(data["IsAdmin"]);
            if (buff == "1")
                this.IsAdmin = true;
            if (buff == "0")
                this.IsAdmin = false;
            if (buff == "NULL")
                this.IsAdmin = false;

        }
    
    }
}
