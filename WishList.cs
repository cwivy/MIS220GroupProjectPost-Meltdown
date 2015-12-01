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
using MIS220GroupProject;

namespace MIS220GroupProject
{
    public partial class WishList : Form
    {
        AggActiveAccount profile = new AggActiveAccount();
        string movieSelect;
        double moviePrice;
        public static int movieID;
        int daysForRent;

        public WishList(AggActiveAccount prof)
        {
            InitializeComponent();
            this.Show();
            profile = prof;
            MovieList mList = new MovieList(prof);
            mList.Hide();
        }

        private void WishList_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            string sqlCmd = "INSERT INTO WishList(movieID) VALUES (@movieID)";
            sqlCmd =  "SELECT m.Title, m.Genre, m.Rating, m.RentalPrice, m.daysForRent FROM WishList as w join Movie as m on w.MovieID = m.MovieID WHERE w.MemberID = @memberID";
           
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sqlCmd, connection))
            using (var adapter = new SqlDataAdapter(command))            
            {
                connection.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@movieID", MovieList.movieID);
                command.Parameters.AddWithValue("@memberID", AggActiveAccount.memberID);
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView1.DataSource = myTable;
            }
        }

        private void returnTo_BOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (returnTo_BOX.SelectedIndex == 0)
            {
                this.Hide();

                MemberHome frm = new MemberHome(profile);
                frm.Show();

            }
            if (returnTo_BOX.SelectedIndex == 1)
            {
                this.Hide();
                MovieList frm = new MovieList(profile);
                frm.Show();
            }
            if (returnTo_BOX.SelectedIndex == 2)
            {
                this.Hide();
               AccountInfo frm = new AccountInfo(profile);
               frm.Show();
            }
        }

        private void removeWishList_BTN_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
            movieSelect = Convert.ToString(row.Cells[0].Value);
            moviePrice = Convert.ToDouble(Convert.ToString(row.Cells[3].Value));
            daysForRent = Convert.ToInt32(Convert.ToString(row.Cells[4].Value));
        }

        private void checkOut_BTN_Click(object sender, EventArgs e)
        {
            Checkout frm = new Checkout(profile, movieSelect, moviePrice, daysForRent);
            frm.Show();
            this.Hide();
        }

    }
}
