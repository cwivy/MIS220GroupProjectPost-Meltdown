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
        private AggActiveAccount thisAGGAcc;
        //constructors-------------------
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            thisAGGAcc = new AggActiveAccount();
            DataSet memberDataSet = new DataSet();

            //Authenticates User
            memberDataSet = thisAGGAcc.CreateAggDataTable(loginUserBox.Text, loginPassBox.Text);

            //if username/pass combo does not exist
            if (memberDataSet.Tables["Table1"].Rows.Count == 0)
            {
                MessageBox.Show("The username or password are invalid.");                
                loginPassBox.Text = " ";                
            }

            else //User is authenticated
            {                
                DataRow memberInfo = memberDataSet.Tables[0].Rows[0];
                string MemberIDString = Convert.ToString(memberInfo["MemberID"]);
                string LoginIDString = Convert.ToString(memberInfo["MemID"]);
                string isAdminString = Convert.ToString(memberInfo["IsAdmin"]);
                //Checks if user is Member or Admin and opens appropriate Home Page
                if (LoginIDString == MemberIDString & isAdminString != "True")
                {
                    this.Hide();
                    new MemberHome(123, 123);
                }
                else if (LoginIDString == MemberIDString & isAdminString == "True")
                {
                    this.Hide();
                    new AdminHome().Show();
                }
            }

            //thisAGGAcc.PopulateMember(memberDataSet.Tables[0].Rows[0]);
            //thisAGGAcc.DisplayMember();
        }

        private void createAccount_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewMemForm().Show();
        }



    }
}
