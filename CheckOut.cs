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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        AggActiveAccount prof;
        public string title;

        public CheckOut Title(string title)
        {
            this.title = title;
            
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
    }
}
