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
    public partial class Checkout : Form
    {
        AggActiveAccount profile;
        string movie;
        public Checkout(AggActiveAccount prof, string movieSelect)
        {
            InitializeComponent();
            profile = prof;
            movie = movieSelect;
            CopyObject2Form(movieSelect, profile);
        }

        public void CopyObject2Form(string movieSelect, AggActiveAccount prof)
        {
            movieTitle_TXT.Text = movieSelect;
            currentBal_TXT.Text = prof.Balance.ToString();
            
        }

        private void checkoutCancel_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieList movieListForm = new MovieList(profile);
            movieListForm.Show();            
        }

        private void checkoutConfirm_BTN_Click(object sender, EventArgs e)
        {

        }
    }
}
