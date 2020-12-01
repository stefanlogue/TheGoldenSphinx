using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoldenSphinx
{
    public partial class frmNewProduct : Form
    {
        SqlDataAdapter daProduct, daSupplier;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBProduct, cmdBSupplier;
        DataRow drProduct;
        string connStr, sqlProduct, sqlSupplier;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            bool ok = true;
            errP.Clear();

            try
            {
                p.ProductNo = Convert.ToInt32(lblProductNoGen.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblProductNoGen, E.ToString());
            }

            try
            {
                p.ProductDesc = txtProductDesc.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtProductDesc, E.ToString());
            }

            try
            {
                p.Price = Convert.ToDouble(txtPrice.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtPrice, E.ToString());
            }

            try
            {
                p.QtyInStock = Convert.ToInt32(txtQtyInStock.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtQtyInStock, E.ToString());
            }

            try
            {
                p.SupplierNo = Convert.ToInt32(cmboSupplierNo.SelectedValue);
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(cmboSupplierNo, E.ToString());
            }

            try
            {
                if (ok)
                {
                    drProduct = dsTheGoldenSphinx.Tables["Product"].NewRow();

                    drProduct["ProductNo"] = p.ProductNo;
                    drProduct["ProductDesc"] = p.ProductDesc;
                    drProduct["Price"] = p.Price;
                    drProduct["QtyInStock"] = p.QtyInStock;
                    drProduct["SupplierNo"] = p.SupplierNo;

                    dsTheGoldenSphinx.Tables["Product"].Rows.Add(drProduct);
                    daProduct.Update(dsTheGoldenSphinx, "Product");

                    MessageBox.Show("Product Added");
                    ClearForm();
                    GetNumber(dsTheGoldenSphinx.Tables["Product"].Rows.Count);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E.TargetSite + "" + E.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        void ClearForm()
        {
            txtProductDesc.Clear();
            txtPrice.Clear();
            txtQtyInStock.Clear();
            cmboSupplierNo.SelectedIndex = -1;
        }

        private void GetNumber(int n)
        {
            drProduct = dsTheGoldenSphinx.Tables["Product"].Rows[n - 1];
            lblProductNoGen.Text = (int.Parse(drProduct["ProductNo"].ToString()) + 1).ToString();
        }

        private void frmNewProduct_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Product");
            daProduct.Fill(dsTheGoldenSphinx, "Product");

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsTheGoldenSphinx, "Supplier");

            cmboSupplierNo.DataSource = dsTheGoldenSphinx.Tables["Supplier"];
            cmboSupplierNo.ValueMember = "SupplierNo";
            cmboSupplierNo.DisplayMember = "SupplierName";

            int noRows = dsTheGoldenSphinx.Tables["Product"].Rows.Count;

            if (noRows == 0)
            {
                lblProductNoGen.Text = "20001";
            }
            else
            {
                GetNumber(noRows);
            }

            //cmboSupplierNo.DataSource =

            errP.Clear();
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmNewProduct()
        {
            InitializeComponent();
        }
    }
}
