using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS220GroupProject
{
    class Order
    {
        private int movieID;
        private int accountID;
        private int rewardID;
        private DateTime rentDate;
        private DateTime dueDate;
        private double total;

        public int MovieID
        {
            get { return movieID; }
            set { movieID = value; }
        }

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public int RewardID
        {
            get { return rewardID; }
            set { rewardID = value; }
        }

        public DateTime RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
