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
    public partial class MovieList : Form
    {
        AggActiveAccount profile;
        string movieSelect;
        double moviePrice;
        int movieID;
        int daysForRent;

        public MovieList(AggActiveAccount prof)
        {
            InitializeComponent();
            this.Show();
            profile = prof;
        }

        private void MovieList_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            string sql = "SELECT * FROM Movie";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                movieListDataGrid.DataSource = myTable;
                connection.Close();
            }
        }

        private void wishList_BTN_Click(object sender, EventArgs e)
        {
            WishList frm = new WishList(profile);
            frm.Show();
            string sqlQuery = "INSERT INTO WishList(Title) VALUES('" + movieSelect + "')";

            string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            SqlConnection dbCon = new SqlConnection(dbStr);

            try
            {
                DataSet memberDataSet = new DataSet();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, dbCon))
                {
                    cmd.Connection.Open();
                    DataTable memberTable = new DataTable();
                    memberTable.Load(cmd.ExecuteReader());
                    memberDataSet.Tables.Add(memberTable);
                }

            }
            finally
            {
                dbCon.Close();
            }

        }

        private void movieListDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = movieListDataGrid.Rows[movieListDataGrid.SelectedCells[0].RowIndex];
            movieSelect = Convert.ToString(row.Cells[0].Value);
            moviePrice = Convert.ToDouble(Convert.ToString(row.Cells[6].Value));
            daysForRent = Convert.ToInt32(Convert.ToString(row.Cells[5].Value));

        }

        private void checkOut_BTN_Click(object sender, EventArgs e)
        {

            Checkout frm = new Checkout(profile, movieSelect, moviePrice, daysForRent);
            //frm.title = movieListDataGrid.CurrentRow.Cells[0].Value.ToString();
            //frm.rentalPrice = movieListDataGrid.CurrentRow.Cells[6].Value.ToString();

            frm.Show();
            this.Hide();
        }

        private void sortBy_DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByGenre_DropBox.SelectedIndex == 0)
            {

            }
            if (sortByGenre_DropBox.SelectedIndex == 1)
            {

            }

        }

        private void backToHome_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberHome form = new MemberHome(profile);
        }

    }
   }