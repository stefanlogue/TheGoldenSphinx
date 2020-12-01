using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
	class Product
	{
		private int productNo, qtyInStock, supplierNo;
		private double price;
		private string productDesc;

		public Product(int productNo, string productDesc, double price, int qtyInStock, int supplierNo)
		{
			this.productNo = productNo;
			this.productDesc = productDesc;
			this.price = price;
			this.qtyInStock = qtyInStock;
			this.supplierNo = supplierNo;
		}

		public Product()
		{
			this.productNo = 0;
			this.productDesc = "";
			this.price = 0.00;
			this.qtyInStock = 0;
			this.supplierNo = 0;
		}

		public int ProductNo
		{
			get { return productNo; }
			set { productNo = value; }
		}

		public int QtyInStock
		{
			get { return qtyInStock; }
			set { qtyInStock = value; }
		}

		public int SupplierNo
		{
			get { return supplierNo; }
			set { supplierNo = value; }
		}

		public string ProductDesc
		{
			get { return productDesc; }
			set
			{
				if (MyValidation.IsValidLetterNumberWhitespace(value))
                {
					productDesc = value;
                }
			}
		}

		public double Price
        {
			get { return price; }
			set
            {
				if (value >= 0.00)
				{
					price = value;
				}
				else
					throw new MyException("Price cannot be negative!");
            }
        }
	}
}
