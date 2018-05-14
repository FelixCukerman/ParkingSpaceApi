using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3_Experimental_.Parking
{
    class Car
    {
        readonly int id;
        public int Id
        {
            get { return id; }
        }

        double cash;
        public double Cash 
        {
            get { return cash;  }
            set { cash = value; }
        }

        readonly CarType category;
        public CarType Category 
        {
            get { return category; }
        }

        public Car(int id, double cash, CarType category)
        {
            this.id = id;
            this.cash = cash;

            this.category = category;
        }

        public void AddCash(double cash)
        {
            this.cash += cash;
        }
    }

    enum CarType
    {
        Passenger = 1,
        Truck,
        Bus,
        Motorcycle
    }
}