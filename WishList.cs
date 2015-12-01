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
    public partial class WishList : Form
    {
        AggActiveAccount profile = new AggActiveAccount();

        public WishList()
        {
            InitializeComponent();
        }

        private void WishList_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = mis220.eil-server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide";
            string sql = "SELECT Title FROM WishList";

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
                MovieList frm = new MovieList();
                frm.Show();
            }
            if (returnTo_BOX.SelectedIndex == 2)
            {
                this.Hide();
                AccountInfo frm = new AccountInfo(profile);
                frm.Show();
            }
        }
    }
}
