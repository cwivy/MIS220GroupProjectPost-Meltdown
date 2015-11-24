using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS220GroupProject
{
    public class Account
    {
        private int accId;
        private int cardNum;
        private double balance;
        private List<int> rentalsHeld;
        private string memStatus;
        private int paymentType;



        public int AccId
        {
            get { return accId; }
            set { accId = value; }
        }

        public int CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<int> RentalsHeld
        {
            get { return rentalsHeld; }
            set { rentalsHeld = value; }
        }

        public string MemStatus
        {
            get { return memStatus; }
            set { memStatus = value; }
        }

        public int PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        
        
    }
}
