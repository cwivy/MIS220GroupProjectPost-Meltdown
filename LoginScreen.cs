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
        private AggActiveAccount userProfile;
        //constructors-------------------
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            userProfile = new AggActiveAccount();
            DataTable memberData = new DataTable();

            //Creates DataTable with all relevant user information
            memberData = AggActiveAccount.CreateAggDataTable(loginUserBox.Text, loginPassBox.Text);

            //if username/pass combo does not exist
            if (memberData.Rows.Count == 0)
            {
                MessageBox.Show("The username or password are invalid.");                
                loginPassBox.Text = " ";                
            }

            else //User is authenticated
            {                
                DataRow memberInfo = memberData.Rows[0];
                userProfile.PopulateProfile(memberData.Rows[0]);
                string MemberIDString = Convert.ToString(memberInfo["MemberID"]);
                string LoginIDString = Convert.ToString(memberInfo["MemID"]);
                string isAdminString = Convert.ToString(memberInfo["IsAdmin"]);
                //Checks if user is Member or Admin and opens appropriate Home Page
                if (LoginIDString == MemberIDString & isAdminString != "True")
                {
                    this.Hide();
                    new MemberHome(userProfile);
                }
                else if (LoginIDString == MemberIDString & isAdminString == "True")
                {
                    this.Hide();
                    new AdminHome().Show();
                }
            }
        }

        private void createAccount_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewMemForm().Show();
        }



    }
}
