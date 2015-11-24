using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS220GroupProject
{
    class Reward
    {
        private int rewardID;
        private double discount;
        private DateTime expirationDate;

        public int RewardID
        {
            get { return rewardID; }
            set { rewardID = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
    }
}
