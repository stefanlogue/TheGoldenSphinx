using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
    class Guest
    {
        private int guestNo;
        private string forename, surname, street, town, county, postcode, telNo;

        public Guest(int guestNo, string forename, string surname, string street, string town, string county, string postcode, string telNo)
        {
            this.guestNo = guestNo;
            this.forename = forename;
            this.surname = surname;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.telNo = telNo;
        }

        public Guest()
        {
            this.guestNo = 0;
            this.forename = "";
            this.surname = "";
            this.street = "";
            this.town = "";
            this.county = "";
            this.postcode = "";
            this.telNo = "";
        }

        public int GuestNo
        {
            get { return guestNo; }
            set { guestNo = value; }
        }

        public string Forename
        {
            get { return forename; }
            set
            {
                if (MyValidation.IsValidLetterLength(value, 2, 32))
                {
                    forename = value;
                }
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (MyValidation.IsValidLetterLength(value, 2, 32))
                {
                    surname = value;
                }
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (MyValidation.IsValidLetterNumberWhitespace(value))
                {
                    street = value;
                }
            }
        }

        public string Town
        {
            get { return town; }
            set
            {
                if (MyValidation.IsValidLetterLength(value, 2, 32))
                {
                    town = value;
                }
            }
        }

        public string County
        {
            get { return county; }
            set
            {
                if (MyValidation.IsValidLetterLength(value, 2, 20))
                {
                    county = value;
                }
            }
        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.IsValidLetterNumberWhitespace(value))
                {
                    postcode = value;
                }
            }
        }

        public string TelNo
        {
            get { return telNo; }
            set
            {
                if (MyValidation.IsValidNumber(value))
                {
                    telNo = value;
                }
            }
        }
    }
}
