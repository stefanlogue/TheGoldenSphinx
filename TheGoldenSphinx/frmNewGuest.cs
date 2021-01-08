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
    public partial class frmNewGuest : Form
    {
        SqlDataAdapter daGuest;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBGuest;
        DataRow drGuest;
        string connStr = Program.connStr;
        string sqlGuest;

        public frmNewGuest()
        {
            InitializeComponent();
        }

        private void frmNewGuest_Load(object sender, EventArgs e)
        {
            sqlGuest = @"select * from Customer";
            daGuest = new SqlDataAdapter(sqlGuest, connStr);
            cmdBGuest = new SqlCommandBuilder(daGuest);
            daGuest.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Customer");
            daGuest.Fill(dsTheGoldenSphinx, "Customer");

            int noRows = dsTheGoldenSphinx.Tables["Customer"].Rows.Count;

            if (noRows == 0)
            {
                lblGuestNoGenerated.Text = "80001";
            }
            else
            {
                GetNumber(noRows);
            }

            errP.Clear();
            ClearForm();
        }

        private void ClearForm()
        {
            txtForename.Clear();
            txtSurname.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtPostcode.Clear();
            txtContactNo.Clear();
        }

        private void GetNumber(int n)
        {
            drGuest = dsTheGoldenSphinx.Tables["Customer"].Rows[n - 1];
            lblGuestNoGenerated.Text = (int.Parse(drGuest["CustomerNo"].ToString()) + 1).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guest g = new Guest();
            bool ok = true;
            errP.Clear();

            try
            {
                g.GuestNo = Convert.ToInt32(lblGuestNoGenerated.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblGuestNoGenerated, E.ToString());
            }

            try
            {
                g.Forename = txtForename.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblForename, E.ToString());
            }

            try
            {
                g.Surname = txtSurname.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblSurname, E.ToString());
            }

            try
            {
                g.Street = txtStreet.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblStreet, E.ToString());
            }

            try
            {
                g.Town = txtTown.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblTown, E.ToString());
            }

            try
            {
                g.County = txtCounty.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblCounty, E.ToString());
            }

            try
            {
                g.Postcode = txtPostcode.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblPostcode, E.ToString());
            }

            try
            {
                g.TelNo = txtContactNo.Text.Trim();
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblContactNo, E.ToString());
            }

            try
            {
                if (ok)
                {
                    drGuest = dsTheGoldenSphinx.Tables["Customer"].NewRow();

                    drGuest["CustomerNo"] = g.GuestNo;
                    drGuest["Forename"] = g.Forename;
                    drGuest["Surname"] = g.Surname;
                    drGuest["Street"] = g.Street;
                    drGuest["Town"] = g.Town;
                    drGuest["County"] = g.County;
                    drGuest["Postcode"] = g.Postcode;
                    drGuest["TelephoneNo"] = g.TelNo;

                    dsTheGoldenSphinx.Tables["Customer"].Rows.Add(drGuest);
                    daGuest.Update(dsTheGoldenSphinx, "Customer");

                    MessageBox.Show("Guest Added");
                    ClearForm();
                    GetNumber(dsTheGoldenSphinx.Tables["Customer"].Rows.Count);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E.TargetSite + "" + E.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
