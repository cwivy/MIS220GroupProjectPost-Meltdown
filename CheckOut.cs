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
        double price;
        public Checkout(AggActiveAccount prof, string movieSelect, double moviePrice)
        {
            InitializeComponent();
            profile = prof;
            movie = movieSelect;
            price = moviePrice;
            CopyObject2Form(movieSelect, profile, moviePrice);
        }

        public void CopyObject2Form(string movieSelect, AggActiveAccount prof, double moviePrice)
        {
            movieTitle_TXT.Text = movieSelect;
            currentBal_TXT.Text = prof.Balance.ToString();
            afterBal_TXT.Text = Convert.ToString((prof.Balance) + (moviePrice));         
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
