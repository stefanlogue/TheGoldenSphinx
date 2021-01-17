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
    public partial class frmViewReservations : Form
    {
        SqlDataAdapter daReservationDetails;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBReservationDetails;
        string connStr = Program.connStr;
        string sqlReservationDetails;

        private void frmViewReservations_Load(object sender, EventArgs e)
        {
            sqlReservationDetails = @"select * from ReservationDetails";
            daReservationDetails = new SqlDataAdapter(sqlReservationDetails, connStr);
            cmdBReservationDetails = new SqlCommandBuilder(daReservationDetails);
            daReservationDetails.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "ReservationDetails");
            daReservationDetails.Fill(dsTheGoldenSphinx, "ReservationDetails");

            dgvViewReservationsGridView.DataSource = dsTheGoldenSphinx.Tables["ReservationDetails"];
            dgvViewReservationsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                dgvViewReservationsGridView.ReadOnly = false;
                btnEdit.Text = "Save";
                btnDelete.Enabled = true;
            }
            else
            {
                daReservationDetails.Update(dsTheGoldenSphinx.Tables["ReservationDetails"]);

                dgvViewReservationsGridView.ReadOnly = true;
                btnEdit.Text = "Edit";
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvViewReservationsGridView.Rows.Remove(dgvViewReservationsGridView.SelectedRows[0]);
            daReservationDetails.Update(dsTheGoldenSphinx.Tables["ReservationDetails"]);
        }

        public frmViewReservations()
        {
            InitializeComponent();
        }
    }
}
