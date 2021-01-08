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
    public partial class frmNewSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        string connStr = Program.connStr;
        string sqlSupplier;

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsTheGoldenSphinx, "Supplier");

            int noRows = dsTheGoldenSphinx.Tables["Supplier"].Rows.Count;

            if (noRows == 0)
            {
                lblSupplierNoGen.Text = "10001";
            }
            else
            {
                GetNumber(noRows);
            }

            errP.Clear();
            ClearForm();
        }

        private void GetNumber(int n)
        {
            drSupplier = dsTheGoldenSphinx.Tables["Supplier"].Rows[n - 1];
            lblSupplierNoGen.Text = (int.Parse(drSupplier["SupplierNo"].ToString()) + 1).ToString();
        }

        private void ClearForm()
        {
            txtContactNo.Clear();
            txtSupplierName.Clear();
            txtPostcode.Clear();
            txtStreet.Clear();
            txtTown.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            bool ok = true;
            errP.Clear();

            try
            {
                s.SupplierNo = Convert.ToInt32(lblSupplierNoGen.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblSupplierNoGen, E.ToString());
            }

            try
            {
                s.SupplierName = txtSupplierName.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtSupplierName, E.ToString());
            }

            try
            {
                s.Contact = txtContactNo.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtContactNo, E.ToString());
            }

            try
            {
                s.Street = txtStreet.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtStreet, E.ToString());
            }

            try
            {
                s.Town = txtTown.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtTown, E.ToString());
            }

            try
            {
                s.Postcode = txtPostcode.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtPostcode, E.ToString());
            }

            try
            {
                if (ok)
                {
                    drSupplier = dsTheGoldenSphinx.Tables["Supplier"].NewRow();

                    drSupplier["SupplierNo"] = s.SupplierNo;
                    drSupplier["SupplierName"] = s.SupplierName;
                    drSupplier["SupplierContact"] = s.Contact;
                    drSupplier["SupplierStreet"] = s.Street;
                    drSupplier["SupplierTown"] = s.Town;
                    drSupplier["SupplierPostcode"] = s.Postcode;

                    dsTheGoldenSphinx.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsTheGoldenSphinx, "Supplier");

                    MessageBox.Show("Supplier Added");
                    ClearForm();
                    GetNumber(dsTheGoldenSphinx.Tables["Supplier"].Rows.Count);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E.TargetSite + "" + E.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmNewSupplier()
        {
            InitializeComponent();
        }
    }
}
