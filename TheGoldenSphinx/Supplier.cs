using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
	class Supplier
	{
		private int supplierNo;
		private string supplierName, contact, street, town, postcode;

		public Supplier(int supplierNo, string supplierName, string contact, string street, string town, string postcode)
		{
			this.supplierNo = supplierNo;
			this.supplierName = supplierName;
			this.contact = contact;
			this.street = street;
			this.town = town;
			this.postcode = postcode;
		}

		public Supplier()
		{
			this.supplierNo = 0;
			this.supplierName = "";
			this.contact = "";
			this.street = "";
			this.town = "";
			this.postcode = "";
		}

		public int SupplierNo
		{
			get { return supplierNo; }
			set { supplierNo = value; }
		}

		public string SupplierName
		{
			get { return supplierName; }
			set
			{
				if (MyValidation.IsValidLetterNumberWhitespace(value))
				{
					supplierName = value;
				}
			}
		}

		public string Contact
        {
			get { return contact; }
            set
            {
				if (MyValidation.IsValidLetterNumberWhitespace(value))
                {
					contact = value;
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
				if (MyValidation.IsValidLetterNumberWhitespace(value))
                {
					town = value;
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
	}
}
