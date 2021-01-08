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
    public partial class frmTable : Form
    {
        SqlDataAdapter daTable;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBTable;
        string connStr = Program.connStr;
        string sqlTable;

        public frmTable()
        {
            InitializeComponent();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlTable = @"select * from Dinner";
            daTable = new SqlDataAdapter(sqlTable, connStr);
            cmdBTable = new SqlCommandBuilder(daTable);
            daTable.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Dinner");
            daTable.Fill(dsTheGoldenSphinx, "Dinner");

            dgvViewTablesGridView.DataSource = dsTheGoldenSphinx.Tables["Dinner"];
            dgvViewTablesGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                dgvViewTablesGridView.ReadOnly = false;
                btnEdit.Text = "Save";
                btnDelete.Enabled = true;
            }
            else
            {
                daTable.Update(dsTheGoldenSphinx.Tables["Dinner"]);

                dgvViewTablesGridView.ReadOnly = true;
                btnEdit.Text = "Edit";
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvViewTablesGridView.Rows.Remove(dgvViewTablesGridView.SelectedRows[0]);
            daTable.Update(dsTheGoldenSphinx.Tables["Dinner"]);
        }
    }
}
