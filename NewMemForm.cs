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
        
        //----------Members--------------
        private Member thisMember;
        private Login thisLogin;
        //private MemberDL thisMemberDL;
        

        //-------Constructors------------
        public NewMemForm()
        {
            thisMember = new Member();
            InitializeComponent();
        }

        //----------Methods--------------
        private void CopyFormToObject()
        {
            thisMember.FName = firstNameBox.Text.ToString();
            thisMember.LName = lastNameBox.Text.ToString();
            thisMember.DateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
            thisMember.Address1 = address1Box.Text.ToString();
            thisMember.Address2 = address2Box.Text.ToString();
            thisMember.City = cityBox.Text.ToString();
            thisMember.State = stateBox.Text.ToString();
            thisMember.Zip = Convert.ToInt32(zipBox.Text);
            thisMember.Phone = Convert.ToString(phoneNumBox);
        }

        private void ClearTextBoxes()
        {
            firstNameBox.Text = " ";
            lastNameBox.Text = " ";
            DOBDateTimePicker.Value = DateTime.Now;
            address1Box.Text = " ";
            address2Box.Text = " ";
            cityBox.Text = " ";
            stateBox.Text = " ";
            zipBox.Text = " ";
            phoneNumBox.Text = " ";
        }

        //--------Event Handlers-----------
        private void saveAccInfoButton_Click(object sender, EventArgs e)
        {

            thisMember = new Member();
            thisLogin = new Login();

            thisMember.FName = firstNameBox.Text;
            thisMember.LName = lastNameBox.Text;
            thisMember.DateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
            thisMember.Address1 = address1Box.Text;
            thisMember.Address2 = address2Box.Text;
            thisMember.City = cityBox.Text;
            thisMember.State = stateBox.Text;
            thisMember.Zip = Convert.ToInt32(zipBox.Text);
            thisMember.Phone = Convert.ToString(phoneNumBox.Text);
            thisLogin.Username = userNameBox.Text;
            thisLogin.Password = passwordBox.Text;

            string DOBString = Convert.ToString(thisMember.DateOfBirth);
            DOBString = DOBString.Substring(0, 10);

            int scopeID = thisMember.CreateAccount(thisMember.FName, thisMember.LName, thisMember.Address1, thisMember.Address2, thisMember.Phone, thisMember.City, thisMember.State, thisMember.Zip, DOBString);
            thisLogin.CreateLogin(thisLogin.Username, thisLogin.Password, scopeID);
            ClearTextBoxes();
            MessageBox.Show("You have successfully created an account!");
        }
    }
}
