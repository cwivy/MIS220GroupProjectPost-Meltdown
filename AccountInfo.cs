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
    public partial class AccountInfo : Form
    {
        AggActiveAccount profile;

        public AccountInfo(AggActiveAccount prof)
        {
            InitializeComponent();
            this.Show();
            profile = prof;
            CopyObject2Form(prof);
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
            paymentType_TXT.Text = prof.PaymentType.ToString();
            //Date joined..?
            birthDate_TXT.Text = prof.DateOfBirth.ToString();
        }

        public AggActiveAccount CopyForm2Object()
        {
            AggActiveAccount prof = new AggActiveAccount();

            return prof;
        }
    }
}
