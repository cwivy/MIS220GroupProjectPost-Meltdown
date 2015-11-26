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
    public partial class LoginScreen : Form
    {
        //Members--------------------------
        private Member thisMember;
        private Login thisLogin;
        //constructors-------------------
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {            
            thisMember = new Member();
            thisLogin = new Login();
            DataSet memberDataSet = new DataSet();
            memberDataSet = thisMember.CreateMemberDataTable(loginUserBox.Text, loginPassBox.Text);

            
            if (memberDataSet.Tables["Table1"].Rows.Count == 0)
            {
                MessageBox.Show("This username and password pair is invalid. Please check that you have the correct information");                
                loginPassBox.Text = " ";                
            }
            else
            {                
                DataRow memberInfo = memberDataSet.Tables[0].Rows[0];
                string MemberIDString = Convert.ToString(memberInfo["MemberID"]);
                string LoginIDString = Convert.ToString(memberInfo["MemID"]);
                string isAdminString = Convert.ToString(memberInfo["IsAdmin"]);
                //Checks if user is Member or Admin and opens appropriate Home Page
                if (LoginIDString == MemberIDString & isAdminString != "True")
                {
                    this.Hide();
                    new MemberHome().Show();
                }
                else if (LoginIDString == MemberIDString & isAdminString == "True")
                {
                    this.Hide();
                    new AdminHome().Show();
                }
            }

            //CARTLON: This just populates the member with the information from the DataTable
            //The pop up box "proves" it's there. Now we need to somehow make the information usable elsewhere
                //First let's tackle the login screen and making the object show up there. We'll need the
                //account balance from the user's account and their name I think for the Home page right now,
                //I just don't know how to do it since the thisMember object only exists on this Login form.
                //I'd love to keep the Member object permanent but I'm worried we may how to query it out every time.
            thisMember.PopulateMember(memberDataSet.Tables[0].Rows[0]);
            thisMember.DisplayMember();
        }

        private void createAccount_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewMemForm().Show();
        }



    }
}
