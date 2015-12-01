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
        AggActiveAccount profile;

        public MemberHome(AggActiveAccount mem)
        {
            InitializeComponent();
            this.Show();
            profile = mem;
            CopyObject2Form(profile);
        }

        public void CopyObject2Form(AggActiveAccount userProfile)
        {
            memNameBox.Text = userProfile.FName + " " + userProfile.LName;
            accBalBox.Text = userProfile.Balance.ToString();
        }

        private void toMovieList_BTN_Click(object sender, EventArgs e)
        {
            MovieList form = new MovieList(profile);
            this.Hide();
        }

        private void toAcctInfoScreen_BTN_Click(object sender, EventArgs e)
        {
            AccountInfo form = new AccountInfo(profile);
            this.Hide();
        }
    }
}
