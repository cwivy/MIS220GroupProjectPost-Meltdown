using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MIS220GroupProject
{
    public partial class AccountInfo : Form
    {
        string firstName;
        string lastName;
        string address1;
        string address2;
        string city;
        string state;
        int zipCode;
        string phoneNum;
        int cardNum;
        string memStatus;
        int paymentType;
        DateTime dateJoined;
        DateTime birthDate;
        int acctID;
        int memID;

        public string FirstName
        {
            get { return firstName;  }

            set { firstName = value; }
        }

        public string LastName
        {
            get  { return lastName; }

            set { lastName = value; }
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

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public DateTime DateJoined
        {
            get { return dateJoined; }
            set { dateJoined = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public int CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
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

        public AccountInfo()
        {
            InitializeComponent();


        }



        private void save_BTN_Click(object sender, EventArgs e)
        {

        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {

        }

        public void fillAccountInfo (int memID, int acctID)
        {
            InitializeComponent();
            this.Show();

        }


    }
}
