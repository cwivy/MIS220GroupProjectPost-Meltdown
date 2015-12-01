using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MIS220GroupProject
{
    public partial class CheckOut : Form 
    {
         

        public CheckOut()
        {
            InitializeComponent();
        }

        AggActiveAccount prof;
        public string title;
        public string rentalPrice;
        public double rentalPrice2;
        public double balance;

        public CheckOut Title(string title)
        {
            this.title = title;
            
            return this;
        }
        
        public CheckOut RentalPrice(string rentalPrice)
        {
            this.rentalPrice2 = Convert.ToDouble(rentalPrice);
            return this;
        }

        public CheckOut Balance(double balance)
        {
            this.balance = balance;
            return this;
        }

        public void movieName_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            MovieList frm = new MovieList(prof);
            movieName_TXT.Text = title;
        }

        private void no_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        

        private void yes_BTN_Click(object sender, EventArgs e)
        {
            rentalPrice2 = Convert.ToDouble(rentalPrice);
            MovieList frm = new MovieList(prof);

            balance -= rentalPrice2;

            string sqlCmd = "UPDATE Account";
            sqlCmd = "SET Balance = " + balance;
            this.Hide();
            MemberHome form = new MemberHome(prof);
            form.Show();
        }
    }
}
