using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS220GroupProject
{
    public partial class NewMemForm : Form
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

        //----------Members--------------        
        private AggActiveAccount thisAGG;
                

        //-------Constructors------------
        public NewMemForm()
        {
            thisAGG = new AggActiveAccount();
            InitializeComponent();
        }

        //----------Methods--------------
        //private void CopyFormToObject()
        //{
        //    thisAGG.FName = firstNameBox.Text.ToString();
        //    thisAGG.LName = lastNameBox.Text.ToString();
        //    thisAGG.DateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
        //    thisAGG.Address1 = address1Box.Text.ToString();
        //    thisAGG.Address2 = address2Box.Text.ToString();
        //    thisAGG.City = cityBox.Text.ToString();
        //    thisAGG.State = stateComboBox.Text.ToString();
        //    thisAGG.Zip = Convert.ToInt32(zipBox.Text);
        //    thisAGG.Phone = Convert.ToString(phoneNumBox);
        //    thisAGG.Username = userNameBox.Text;
        //    thisAGG.Password = passwordBox.Text;
        //}

        private void ClearTextBoxes()
        {
            firstNameBox.Text = " ";
            lastNameBox.Text = " ";
            DOBDateTimePicker.Value = DateTime.Now;
            address1Box.Text = " ";
            address2Box.Text = " ";
            cityBox.Text = " ";
            stateComboBox.Text = " ";
            zipBox.Text = " ";
            phoneNumBox.Text = " ";
        }

        //--------Event Handlers-----------
        private void saveAccInfoButton_Click(object sender, EventArgs e)
        {
            //account info
            if(Convert.ToString(cardTypeDropBox.Text) == "Debit")
            { paymentType = 1; }
            else 
            { paymentType = 0; }
            cardNum = Convert.ToInt32(cardNumberBox.Text);
            //member info
            fName = firstNameBox.Text;
            lName = lastNameBox.Text;
            address1 = address1Box.Text;
            address2 = address2Box.Text;
            phone = phoneNumBox.Text;
            city = cityBox.Text;
            state = stateComboBox.Text;
            zip = Convert.ToInt32(zipBox.Text);
            dateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
            //login info
            username = userNameBox.Text;
            password = passwordBox.Text;

            string cardNumString = Convert.ToString(cardNum);
            string paymentTypeString = Convert.ToString(paymentType);
            string DOBString = Convert.ToString(dateOfBirth);
            DOBString = DOBString.Substring(0, 10);

            thisAGG.CreateNewProfile(cardNumString, paymentTypeString, fName, lName, DOBString, address1, address2, city, state, zip, phone, username, password);
            ClearTextBoxes();
            MessageBox.Show("You have successfully created an account!");
        }

        private void cardTypeDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set combo box as a drop down style so input could be controlled to desired responses
            //see list of options in form design by clicking on 'edit items' in properties description
            cardTypeDropBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
