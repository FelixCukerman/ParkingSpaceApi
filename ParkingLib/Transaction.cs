using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3_Experimental_.Parking
{
    [Serializable]
    class Transaction
    {
        readonly DateTime date;
        public DateTime Date
        {
            get { return date; }
        }

        readonly int id;
        public int Id
        {
            get { return id; }
        }

        readonly int payment;
        public int Payment
        {
            get { return payment; }
        }

        public Transaction(int id, int payment)
        {
            this.date = DateTime.Now;
            this.id = id;
            this.payment = payment;
        }
    }
}