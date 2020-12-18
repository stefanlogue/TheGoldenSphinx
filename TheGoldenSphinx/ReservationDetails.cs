using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
    class ReservationDetails
    {
        private int reservationNo, tableNo, productNo, productQty;
        private DateTime dateOfReservation;

        public ReservationDetails(int reservationNo, int tableNo, int productNo, int productQty, DateTime dateOfReservation)
        {
            this.reservationNo = reservationNo;
            this.tableNo = tableNo;
            this.productNo = productNo;
            this.productQty = productQty;
            this.dateOfReservation = dateOfReservation;
        }

        public ReservationDetails()
        {
            this.reservationNo = 0;
            this.tableNo = 0;
            this.productNo = 0;
            this.productQty = 0;
            this.dateOfReservation = DateTime.Now;
        }

        public int ReservationNo
        {
            get { return reservationNo; }
            set { reservationNo = value; }
        }

        public int TableNo
        {
            get { return tableNo; }
            set { tableNo = value; }
        }

        public int ProductNo
        {
            get { return productNo; }
            set { productNo = value; }
        }

        public int ProductQty
        {
            get { return productQty; }
            set { productQty = value; }
        }

        public DateTime DateOfReservation
        {
            get { return dateOfReservation; }
            set { dateOfReservation = value; }
        }
    }
}
