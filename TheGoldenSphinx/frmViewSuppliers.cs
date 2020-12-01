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
        DataRow drSupplier;
        string connStr, sqlSupplier;
        public frmViewSuppliers()
        {
            InitializeComponent();
        }

        private void frmViewSuppliers_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlSupplier = @"select * from Product";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Product");
            daSupplier.Fill(dsTheGoldenSphinx, "Product");

            dgvViewSuppliersGridView.DataSource = dsTheGoldenSphinx.Tables["Product"];
            dgvViewSuppliersGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnViewSuppliersCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
