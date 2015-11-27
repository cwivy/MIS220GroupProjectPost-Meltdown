using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MIS220GroupProject
{
    public class Member : Account

    {

        //--------Members-------------  	
	
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
        

       //----------Properties------------
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

        //--------Constructors-------------

        //Use this when you want to test something with a member and dont want to deal with SQL
        //I will also create an Account constructor to go with it
        public Member()
        {
            this.Id = 1337;
            this.AccId = 1969;
            this.FName = "Nicholas";
            this.LName = "Cage";
            this.DateOfBirth = Convert.ToDateTime("10-14-1978");
            this.Address1 = "555 Cage Drive";
            this.Address2 = "555 Declaration of Independence Lane";
            this.City = "Washington D.C.";
            this.State = "NA";
            this.Zip = 55555;
            this.Phone = "(555) 123-4567";
        }


        
 

        //public DataSet CreateMemberDataTable(string userName, string password)
        //{
        //    //SQL Statement for creating new member
        //    string sqlQuery = "declare @userName varchar(50), @password varchar(50)" +
        //    " set @userName = '" + userName + "' set @password = '" + password + "'" +
        //    "SELECT * FROM Login l, Member m where l.Username = @userName and l.Password = @password and l.MemberID = m.MemID;";

        //    //Establishes connection with SQL DB
        //    string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
        //    SqlConnection dbCon = new SqlConnection(dbStr);

        //    try
        //    {
        //        DataSet memberDataSet = new DataSet();
        //        using (SqlCommand cmd = new SqlCommand(sqlQuery, dbCon))
        //        {
        //            cmd.Connection.Open();
        //            DataTable memberTable = new DataTable();
        //            memberTable.Load(cmd.ExecuteReader());
        //            //string tableName = "MemberInfoTable";
        //            memberDataSet.Tables.Add(memberTable);
        //        }
        //        return memberDataSet;
        //    }
        //    finally
        //    {
        //        dbCon.Close();
        //    }

        //}
	//createAggMemberInfo

        public void PopulateMember(DataRow memTable)
        {
            this.Id = Convert.ToInt32(Convert.ToString(memTable["MemID"]));
            //mem.AccId = Convert.ToInt32(Convert.ToString(memTable["AccountID"]));
            this.FName = Convert.ToString(memTable["FirstName"]);
            this.LName = Convert.ToString(memTable["LastName"]);
            this.Address1 = Convert.ToString(memTable["Address1"]);
            this.Address2 = Convert.ToString(memTable["Address2"]);
            this.Phone = Convert.ToString(memTable["Phone"]);
            this.City = Convert.ToString(memTable["City"]);
            this.State = Convert.ToString(memTable["State"]);
            this.zip = Convert.ToInt32(Convert.ToString(memTable["Zip"]));
            this.dateOfBirth = Convert.ToDateTime(memTable["DOB"]); 
        }

        //I'm considering getting rid of this since we have the DataTable and Populate functions that do this in less
        //lines of code. I think that's more efficient, idk though.
        //public Member Select(int MemID)
        //{
        //    string sqlText;
        //    sqlText = "SELECT * FROM Member WHERE MemID = @MemID";

        //    Member member = new Member();

        //    //Establishes connection with SQL DB
        //    string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
        //    SqlConnection dbCon = new SqlConnection(dbStr);

        //    SqlCommand command = new SqlCommand(sqlText, dbCon);
        //    command.CommandType = CommandType.Text;
        //    command.Parameters.AddWithValue("@MemID", MemID);

        //    dbCon.Open();

        //    SqlDataReader reader = command.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        reader.Read();

        //        if (reader.IsDBNull(0) == false)
        //            member.Id = reader.GetInt32(0);

        //        //if (reader.IsDBNull(1) == false)
        //        //    member.AccId = reader.GetInt32(1);

        //        if (reader.IsDBNull(2) == false)
        //            member.FName = reader.GetString(2);

        //        if (reader.IsDBNull(3) == false)
        //            member.LName = reader.GetString(3);

        //        if (reader.IsDBNull(4) == false)
        //            member.DateOfBirth = Convert.ToDateTime(reader.GetDateTime(4));

        //        if (reader.IsDBNull(5) == false)
        //            member.Address1 = reader.GetString(5);

        //        if (reader.IsDBNull(6) == false)
        //            member.Address2 = reader.GetString(6);

        //        if (reader.IsDBNull(7) == false)
        //            member.City = reader.GetString(7);

        //        if (reader.IsDBNull(8) == false)
        //            member.State = reader.GetString(8);

        //        if (reader.IsDBNull(9) == false)
        //            member.Zip = reader.GetInt32(9);

        //        if (reader.IsDBNull(10) == false)
        //            member.Phone = reader.GetString(10);
        //    }

        //    reader.Close();
        //    dbCon.Close();

        //    sqlText = "SELECT * FROM Account as a INNER JOIN Member as m on a.AccountID = m.AccountID";
        //    sqlText = "WHERE a.AccountID = @AccountID";

        //    command.CommandType = CommandType.Text;
        //    command.Parameters.AddWithValue("@AccountID", member.AccId);

        //    dbCon.Open();

        //    reader = command.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        reader.Read();

        //        if (reader.IsDBNull(0) == false)
        //            member.AccId = reader.GetInt32(0);

        //        if (reader.IsDBNull(1) == false)
        //            member.MemStatus = reader.GetString(1);

        //        if (reader.IsDBNull(2) == false)
        //            member.Balance = reader.GetDouble(2);

        //        if (reader.IsDBNull(3) == false)
        //            member.CardNum = reader.GetInt32(3);

        //        if (reader.IsDBNull(4) == false)
        //            member.PaymentType = reader.GetInt32(4);
        //    }

        //    reader.Close();
        //    command.Dispose();
        //    dbCon.Close();

        //    return member;
        //}

        //Creates a pop up box that just outputs the information in a member object in an easily readable way
        //Mostly just for testing purposes
        public void DisplayMember()
        {
            MessageBox.Show("MemberID: " + this.Id + "\n" +
                            "AccountID: " + this.AccId + "\n" +
                            "First Name: " + this.FName + "\n" +
                            "Last Name: " + this.LName + "\n" +
                            "Address1: " + this.Address1 + "\n" +
                            "Address2: " + this.Address2 + "\n" +
                            "Phone: " + this.Phone + "\n" +
                            "City: " + this.City + "\n" +
                            "State: " + this.State + "\n" +
                            "Zip: " + this.Zip + "\n" +
                            "DOB: " + this.dateOfBirth + "\n");
        }
    }

}
