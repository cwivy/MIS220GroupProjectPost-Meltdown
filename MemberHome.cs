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
    public partial class MemberHome : Form
    {

        public MemberHome(AggActiveAccount mem)
        {
            InitializeComponent();
            this.Show();
            AggActiveAccount member = new AggActiveAccount();
            member = mem;
            CopyObject2Form(member);
        }

        public void CopyObject2Form(AggActiveAccount userProfile)
        {
            memNameBox.Text = userProfile.FName + " " + userProfile.LName;
            accBalBox.Text = userProfile.Balance.ToString();
        }
    }
}
