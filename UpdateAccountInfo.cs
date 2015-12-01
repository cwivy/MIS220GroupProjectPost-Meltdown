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
    public partial class UpdateAccountInfo : Form
    {
        AggActiveAccount profile;
        public UpdateAccountInfo(AggActiveAccount prof)
        {
            InitializeComponent();
            profile = prof;
            CopyObject2Form(profile);
            this.Show();
        }

        private void UpdateAccountInfo_Load(object sender, EventArgs e)
        {

        }

        public void CopyObject2Form(AggActiveAccount prof)
        {
            firstName_TXT.Text = prof.FName;
            lastName_TXT.Text = prof.LName;
            address1_TXT.Text = prof.Address1;
            address2_TXT.Text = prof.Address2;
            city_TXT.Text = prof.City;
            state_TXT.Text = prof.State;
            zip_TXT.Text = prof.Zip.ToString();
            phone_TXT.Text = prof.Phone;
            cardNum_TXT.Text = prof.CardNum.ToString();
            memStatus_TXT.Text = prof.MemStatus;
            if (prof.PaymentType == 1)
                cardTypeDropBox.Text = "Credit";
            if (prof.PaymentType == 0)
                cardTypeDropBox.Text = "Debit";
            //Date joined..?
            dateTimePicker1.Value = prof.DateOfBirth;
        }

        public AggActiveAccount CopyForm2Object(AggActiveAccount profile)
        {
            profile.FName = firstName_TXT.Text;
            profile.LName = lastName_TXT.Text;
            profile.Address1 = address1_TXT.Text;
            profile.Address2 = address2_TXT.Text;
            profile.City = city_TXT.Text;
            profile.State = state_TXT.Text;
            profile.Zip = Convert.ToInt32(zip_TXT.Text);
            profile.Phone = phone_TXT.Text;
            profile.MemStatus = memStatus_TXT.Text;
            profile.CardNum = Convert.ToInt64(cardNum_TXT.Text);
            if (cardTypeDropBox.Text == "Credit")
                profile.PaymentType = 1;
            if (cardTypeDropBox.Text == "Debit")
                profile.PaymentType = 0;
            return profile;
        }

        private void saveAcctInfo_BTN_Click(object sender, EventArgs e)
        {
            profile = CopyForm2Object(profile);
            //SQL Stuff to update Account

            this.Hide();
            AccountInfo form = new AccountInfo(profile);
            form.Show();
        }
    }
}
