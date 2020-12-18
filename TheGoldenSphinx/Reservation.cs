using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
    class Reservation
    {
        private int reservationNo, customerNo;
        private DateTime reservedDate;

        public Reservation(int reservationNo, int customerNo, DateTime reservedDate)
        {
            this.reservationNo = reservationNo;
            this.customerNo = customerNo;
            this.reservedDate = reservedDate;
        }

        public Reservation()
        {
            this.reservationNo = 0;
            this.customerNo = 0;
            this.reservedDate = DateTime.Now;
        }

        public int ReservationNo
        {
            get { return reservationNo; }
            set { reservationNo = value; }
        }

        public int CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        public DateTime ReservedDate
        {
            get { return reservedDate; }
            set { reservedDate = value; }
        }
    }
}
