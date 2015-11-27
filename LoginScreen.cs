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
            //passes the username and password from the form to check the SQL database for a match
            memberDataSet = thisAGGAcc.CreateAggDataTable(loginUserBox.Text, loginPassBox.Text);

            //if a row is not returned is the dataset then the username/password pair does not exist
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
                        
        }

        private void createAccount_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewMemForm().Show();
        }



    }
}
