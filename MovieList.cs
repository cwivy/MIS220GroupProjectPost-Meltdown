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
        string Title;

        public MovieList(AggActiveAccount prof)
        {
            InitializeComponent();
            profile = prof;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string dbStr = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
        //    string sqlIns = "SELECT Title, Genre, ReleaseDate, Rating FROM dbo.Movie WHERE title = '" + listBox1.Text + "';";
        //    SqlConnection conDataBase = new SqlConnection(dbStr);
        //    SqlCommand cmdIns = new SqlCommand(sqlIns, conDataBase);
        //    SqlDataReader myReader;

        //    try
        //    {
        //        conDataBase.Open();
        //        myReader = cmdIns.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            string mTitle = myReader.GetString("Title");
        //            listBox1.Items.Add(mTitle);
        //            string mGenre = myReader.GetString("Genre");
        //            listBox1.Items.Add(mGenre);
        //            string mReleaseDate = myReader.GetString("ReleaseDate");
        //            listBox1.Items.Add(mReleaseDate);
        //            string mRating = myReader.GetString("Rating");
        //            listBox1.Items.Add(mRating);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        }

        private void MovieList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet.Movie' table. You can move, or remove it, as needed.
            //this.movieTableAdapter.Fill(this.movieRentalDataSet.Movie);

            string connectionString = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            string sql = "SELECT * FROM Movie";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView1.DataSource = myTable;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnTo_BOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (returnTo_BOX.SelectedIndex == 0)
            {
                this.Hide();
                MemberHome frm = new MemberHome(profile);
                frm.Show();
                
            }
            if(returnTo_BOX.SelectedIndex == 1)
            {
                this.Hide();

            }
            if(returnTo_BOX.SelectedIndex == 2)
            {
                this.Hide();
                AccountInfo frm = new AccountInfo(profile);
                frm.Show();
            }
        }

        private void wishList_BTN_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO WishList(Title) VALUES('" + Title + "')";

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
                    //string tableName = "MemberInfoTable";
                    memberDataSet.Tables.Add(memberTable);
                }

            }
            finally
            {
                dbCon.Close();
            }

        }
    }
}
