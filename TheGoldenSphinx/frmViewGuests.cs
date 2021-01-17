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
    public partial class frmViewGuests : Form
    {
        SqlDataAdapter daGuest;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBGuest;
        string connStr = Program.connStr;
        string sqlGuest;

        public frmViewGuests()
        {
            InitializeComponent();
        }

        private void frmViewGuests_Load(object sender, EventArgs e)
        {
            sqlGuest = @"select * from Customer";
            daGuest = new SqlDataAdapter(sqlGuest, connStr);
            cmdBGuest = new SqlCommandBuilder(daGuest);
            daGuest.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Customer");
            daGuest.Fill(dsTheGoldenSphinx, "Customer");

            dgvViewGuestsGridView.DataSource = dsTheGoldenSphinx.Tables["Customer"];
            dgvViewGuestsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                dgvViewGuestsGridView.ReadOnly = false;
                btnEdit.Text = "Save";
                btnDelete.Enabled = true;
            }
            else
            {
                daGuest.Update(dsTheGoldenSphinx.Tables["Customer"]);

                dgvViewGuestsGridView.ReadOnly = true;
                btnEdit.Text = "Edit";
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvViewGuestsGridView.Rows.Remove(dgvViewGuestsGridView.SelectedRows[0]);
            daGuest.Update(dsTheGoldenSphinx.Tables["Customer"]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
