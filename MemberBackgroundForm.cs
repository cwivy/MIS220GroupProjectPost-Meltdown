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
    public partial class MemberBackgroundForm : Form
    {
        
        public MemberBackgroundForm(AggActiveAccount prof)
        {
            InitializeComponent();
            CopyObject2Form(prof);
        }

        public void CopyObject2Form(AggActiveAccount profile)
        {
            MemID_TXT.Text = profile.MemId.ToString();
            firstName_TXT.Text = profile.FName;
            lastName_TXT.Text = profile.LName;
            address1_TXT.Text = profile.Address1;
            address2_TXT.Text = profile.Address2;
            city_TXT.Text = profile.City;
            state_TXT.Text = profile.State;
            zip_TXT.Text = profile.Zip.ToString();
            phone_TXT.Text = profile.Phone.ToString();
            accountID_TXT.Text = profile.AccId.ToString();
            memStatus_TXT.Text = profile.MemStatus;
            balance_TXT.Text = profile.Balance.ToString();
            cardNum_TXT.Text = profile.CardNum.ToString();
            paymentType_TXT.Text = profile.PaymentType.ToString();
            DOBDateTimePicker.Value = profile.DateOfBirth;
        }

        public AggActiveAccount CopyForm2Object()
        {
            AggActiveAccount profile = new AggActiveAccount();
            profile.MemId = Convert.ToInt32(MemID_TXT.Text);
            profile.FName = firstName_TXT.Text;
            profile.LName = lastName_TXT.Text;
            profile.Address1 = address1_TXT.Text;
            profile.Address2 = address2_TXT.Text;
            profile.City = city_TXT.Text;
            profile.State = state_TXT.Text;
            profile.Zip = Convert.ToInt32(zip_TXT.Text);
            profile.Phone = phone_TXT.Text;
            profile.AccId = Convert.ToInt32(accountID_TXT.Text);
            profile.MemStatus = memStatus_TXT.Text;
            profile.Balance = Convert.ToDouble(balance_TXT.Text);
            profile.CardNum = Convert.ToInt64(cardNum_TXT);
            profile.PaymentType = Convert.ToInt32(paymentType_TXT);
            profile.DateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Value);
            return profile;
        }
    }
}
