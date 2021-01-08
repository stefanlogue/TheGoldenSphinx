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
    public partial class frmViewProducts : Form
    {
        SqlDataAdapter daProduct;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBProduct;
        string connStr = Program.connStr;
        string sqlProduct;

        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void btnViewProductsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViewProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewProductsEdit_Click(object sender, EventArgs e)
        {
            if (btnViewProductsEdit.Text == "Edit")
            {
                dgvViewProductsGridView.ReadOnly = false;
                btnViewProductsEdit.Text = "Save";
                btnViewProductsDelete.Enabled = true;
            }
            else
            {
                daProduct.Update(dsTheGoldenSphinx.Tables["Product"]);

                dgvViewProductsGridView.ReadOnly = true;
                btnViewProductsEdit.Text = "Edit";
                btnViewProductsDelete.Enabled = false;
            }
        }

        private void btnViewProductsDelete_Click(object sender, EventArgs e)
        {
            dgvViewProductsGridView.Rows.Remove(dgvViewProductsGridView.SelectedRows[0]);
            daProduct.Update(dsTheGoldenSphinx.Tables["Product"]);
        }

        private void frmViewProducts_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Product");
            daProduct.Fill(dsTheGoldenSphinx, "Product");

            dgvViewProductsGridView.DataSource = dsTheGoldenSphinx.Tables["Product"];
            dgvViewProductsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvViewProductsGridView.Columns["Price"].DefaultCellStyle.Format = "c";
        }
    }
}
