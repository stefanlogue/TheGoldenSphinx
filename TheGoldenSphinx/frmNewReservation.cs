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
    public partial class frmNewReservation : Form
    {
        SqlDataAdapter daReservation, daReservationDetails, daTable, daProduct, daCustomer;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBReservation, cmdBReservationDetails, cmdBTable, cmdBProduct, cmdBCustomer;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataRow drReservation, drReservationDetails;
        string connStr, sqlReservation, sqlReservationDetails, sqlTable, sqlProduct, sqlCustomer;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            ReservationDetails rd = new ReservationDetails();
            bool ok = true;
            errP.Clear();

            try
            {
                r.ReservationNo = Convert.ToInt32(lblReservationNoGen.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblReservationNoGen, E.ToString());
            }

            try
            {
                rd.ReservationNo = Convert.ToInt32(lblReservationNoGen.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(lblReservationNoGen, E.ToString());
            }

            try
            {
                r.CustomerNo = Convert.ToInt32(cmboCustNo.SelectedValue);
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(cmboCustNo, E.ToString());
            }

            try
            {
                r.ReservedDate = dtReservedOn.Value;
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(dtReservedOn, E.ToString());
            }

            try
            {
                rd.TableNo = Convert.ToInt32(cmboTableNo.SelectedValue);
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(cmboTableNo, E.ToString());
            }

            try
            {
                rd.DateOfReservation = dtReservedFor.Value;
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(dtReservedFor, E.ToString());
            }

            try
            {
                rd.ProductNo = Convert.ToInt32(cmboProductNo.SelectedValue);
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(cmboProductNo, E.ToString());
            }

            try
            {
                rd.ProductQty = Convert.ToInt32(txtQty.Text.Trim());
            }
            catch (MyException E)
            {
                ok = false;
                errP.SetError(txtQty, E.ToString());
            }

            try
            {
                if (ok)
                {
                    drReservation = dsTheGoldenSphinx.Tables["Reservation"].NewRow();

                    drReservation["ReservationNo"] = r.ReservationNo;
                    drReservation["CustomerNo"] = r.CustomerNo;
                    drReservation["ReservedDate"] = r.ReservedDate;

                    dsTheGoldenSphinx.Tables["Reservation"].Rows.Add(drReservation);
                    daReservation.Update(dsTheGoldenSphinx, "Reservation");

                    drReservationDetails = dsTheGoldenSphinx.Tables["ReservationDetails"].NewRow();

                    drReservationDetails["ReservationNo"] = rd.ReservationNo;
                    drReservationDetails["TableNo"] = rd.TableNo;
                    drReservationDetails["DateOfReservation"] = rd.DateOfReservation;
                    drReservationDetails["ProductNo"] = rd.ProductNo;
                    drReservationDetails["ProductQty"] = rd.ProductQty;

                    dsTheGoldenSphinx.Tables["ReservationDetails"].Rows.Add(drReservationDetails);
                    daReservationDetails.Update(dsTheGoldenSphinx, "ReservationDetails");

                    MessageBox.Show("Reservation Added");
                    ClearForm();
                    GetNumber(dsTheGoldenSphinx.Tables["Reservation"].Rows.Count);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E.TargetSite + "" + E.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        public frmNewReservation()
        {
            InitializeComponent();
        }
        private void frmNewReservation_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlReservation = @"select * from Reservation";
            daReservation = new SqlDataAdapter(sqlReservation, connStr);
            cmdBReservation = new SqlCommandBuilder(daReservation);
            daReservation.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Reservation");
            daReservation.Fill(dsTheGoldenSphinx, "Reservation");

            sqlReservationDetails = @"select * from ReservationDetails";
            daReservationDetails = new SqlDataAdapter(sqlReservationDetails, connStr);
            cmdBReservationDetails = new SqlCommandBuilder(daReservationDetails);
            daReservationDetails.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "ReservationDetails");
            daReservationDetails.Fill(dsTheGoldenSphinx, "ReservationDetails");

            sqlTable = @"select * from Dinner";
            daTable = new SqlDataAdapter(sqlTable, connStr);
            cmdBTable = new SqlCommandBuilder(daTable);
            daTable.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Dinner");
            daTable.Fill(dsTheGoldenSphinx, "Dinner");

            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Product");
            daProduct.Fill(dsTheGoldenSphinx, "Product");

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Customer");
            daCustomer.Fill(dsTheGoldenSphinx, "Customer");

            cmboCustNo.DataSource = dsTheGoldenSphinx.Tables["Customer"];
            cmboCustNo.ValueMember = "CustomerNo";
            cmboCustNo.DisplayMember = "Surname";

            cmboTableNo.DataSource = dsTheGoldenSphinx.Tables["Dinner"];
            cmboTableNo.ValueMember = "TableNo";
            cmboTableNo.DisplayMember = "TableNo";

            cmboProductNo.DataSource = dsTheGoldenSphinx.Tables["Product"];
            cmboProductNo.ValueMember = "ProductNo";
            cmboProductNo.DisplayMember = "ProductDesc";

            int noRows = dsTheGoldenSphinx.Tables["ReservationDetails"].Rows.Count;

            if (noRows == 0)
            {
                lblReservationNoGen.Text = "50001";
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
            cmboCustNo.SelectedIndex = -1;
            dtReservedOn.Value = DateTime.Today;
            cmboTableNo.SelectedIndex = -1;
            dtReservedFor.Value = DateTime.Today;
            cmboProductNo.SelectedIndex = -1;
            txtQty.Clear();
        }

        private void GetNumber(int n)
        {
            drReservationDetails = dsTheGoldenSphinx.Tables["ReservationDetails"].Rows[n - 1];
            lblReservationNoGen.Text = (int.Parse(drReservationDetails["ReservationNo"].ToString()) + 1).ToString();
        }

    }
}
