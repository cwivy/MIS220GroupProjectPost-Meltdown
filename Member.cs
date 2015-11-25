using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MIS220GroupProject
{
    public class Member : Account
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


        public int CreateAccount(string fName, string lName, string address1, string address2, string phone, string city, string state, Int32 zip, string dateOfBirth)
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
 
        public void CreateMemberDataTable(string userName, string password)
        {
            //SQL Statement for creating new member
            string sqlQuery = "declare @userName varchar(50), @password varchar(50)" +
            " set @userName = '" + userName + "' set @password = '" + password + "'" +
            "select *from Login l, Member m where l.Username = @userName and l.Password = @password and l.MemberID = m.MemID;";

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {

            }

        }

        public Member Select(int MemID)
        {
            string sqlText;
            sqlText = "SELECT * FROM Member WHERE MemID = @MemID";

            Member member = new Member();

            //Establishes connection with SQL DB
            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            SqlCommand command = new SqlCommand(sqlText, dbCon);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MemID", MemID);

            dbCon.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                if (reader.IsDBNull(0) == false)
                    member.Id = reader.GetInt32(0);

                //if (reader.IsDBNull(1) == false)
                //    member.AccId = reader.GetInt32(1);

                if (reader.IsDBNull(2) == false)
                    member.FName = reader.GetString(2);

                if (reader.IsDBNull(3) == false)
                    member.LName = reader.GetString(3);

                if (reader.IsDBNull(4) == false)
                    member.DateOfBirth = Convert.ToDateTime(reader.GetDateTime(4));

                if (reader.IsDBNull(5) == false)
                    member.Address1 = reader.GetString(5);

                if (reader.IsDBNull(6) == false)
                    member.Address2 = reader.GetString(6);

                if (reader.IsDBNull(7) == false)
                    member.City = reader.GetString(7);

                if (reader.IsDBNull(8) == false)
                    member.State = reader.GetString(8);

                if (reader.IsDBNull(9) == false)
                    member.Zip = reader.GetInt32(9);

                if (reader.IsDBNull(10) == false)
                    member.Phone = reader.GetString(10);
            }

            reader.Close();
            dbCon.Close();

            sqlText = "SELECT * FROM Account as a INNER JOIN Member as m on a.AccountID = m.AccountID";
            sqlText = "WHERE a.AccountID = @AccountID";

            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@AccountID", member.AccId);

            dbCon.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                if (reader.IsDBNull(0) == false)
                    member.AccId = reader.GetInt32(0);

                if (reader.IsDBNull(1) == false)
                    member.MemStatus = reader.GetString(1);

                if (reader.IsDBNull(2) == false)
                    member.Balance = reader.GetDouble(2);

                if (reader.IsDBNull(3) == false)
                    member.CardNum = reader.GetInt32(3);

                if (reader.IsDBNull(4) == false)
                    member.PaymentType = reader.GetInt32(4);
            }

            reader.Close();
            command.Dispose();
            dbCon.Close();

            return member;
        }
    }

}
