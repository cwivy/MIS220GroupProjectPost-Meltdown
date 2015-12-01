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
        public MovieList()
        {
            InitializeComponent();
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
    }
}
