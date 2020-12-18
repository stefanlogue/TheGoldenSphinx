using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
    class Table
    {
        private int tableNo, maxSeats;

        public Table(int tableNo, int maxSeats)
        {
            this.tableNo = tableNo;
            this.maxSeats = maxSeats;
        }

        public Table()
        {
            this.tableNo = 0;
            this.maxSeats = 0;
        }

        public int TableNo
        {
            get { return tableNo; }
            set { tableNo = value; }
        }

        public int MaxSeats
        {
            get { return maxSeats; }
            set { maxSeats = value; }
        }
    }
}
