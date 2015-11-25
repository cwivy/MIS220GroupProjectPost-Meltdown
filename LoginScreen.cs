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
