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
        string connStr, sqlReservationDetails;

        private void frmViewReservations_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

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

        public frmViewReservations()
        {
            InitializeComponent();
        }
    }
}
