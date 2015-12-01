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
        //public MemberHome()
        //{
        //    InitializeComponent();
        //}

        public MemberHome(int memID, int accID)
        {
            InitializeComponent();
            this.Show();
        }
    }
}
