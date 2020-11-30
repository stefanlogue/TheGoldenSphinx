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
        DataRow drProduct;
        string connStr, sqlProduct;

        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void btnViewProductsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewProducts_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Product");
            daProduct.Fill(dsTheGoldenSphinx, "Product");

            dgvViewProductsGridView.DataSource = dsTheGoldenSphinx.Tables["Product"];
            dgvViewProductsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
