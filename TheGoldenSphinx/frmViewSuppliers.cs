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
    public partial class frmViewSuppliers : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        string connStr = Program.connStr;
        string sqlSupplier;

        public frmViewSuppliers()
        {
            InitializeComponent();
        }

        private void frmViewSuppliers_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsTheGoldenSphinx, "Supplier");

            dgvViewSuppliersGridView.DataSource = dsTheGoldenSphinx.Tables["Supplier"];
            dgvViewSuppliersGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnViewSuppliersEdit_Click(object sender, EventArgs e)
        {
            if (btnViewSuppliersEdit.Text == "Edit")
            {
                dgvViewSuppliersGridView.ReadOnly = false;
                btnViewSuppliersEdit.Text = "Save";
                btnViewSuppliersDelete.Enabled = true;
                
            }
            else
            {
                daSupplier.Update(dsTheGoldenSphinx.Tables["Supplier"]);
                dgvViewSuppliersGridView.EndEdit();

                dgvViewSuppliersGridView.ReadOnly = true;
                btnViewSuppliersEdit.Text = "Edit";
                btnViewSuppliersDelete.Enabled = false;
            }
        }

        private void btnViewSuppliersDelete_Click(object sender, EventArgs e)
        {
            dgvViewSuppliersGridView.Rows.Remove(dgvViewSuppliersGridView.SelectedRows[0]);
            daSupplier.Update(dsTheGoldenSphinx.Tables["Supplier"]);
        }

        private void btnViewSuppliersCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
