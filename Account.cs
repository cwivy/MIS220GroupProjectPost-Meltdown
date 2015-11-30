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
        private long cardNum;
        private double balance;
        private List<int> rentalsHeld;
        private string memStatus;
        private int paymentType;



        public int AccId
        {
            get { return accId; }
            set { accId = value; }
        }

        public long CardNum
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

        //----------Constructors---------
        public Account()
        {
            this.AccId = 80085;
            this.Balance = 12.00;
            this.CardNum = 123456789000;
            //this.RentalsHeld.Add = 1; How to add to list....
            this.MemStatus = "Gold";
            this.PaymentType = 1;

        }
        
        //Carlton: reminder Create a function for pop up message to display account information AND one that will
        //populate an object with information from a DataTable just like in Member
    }
}
