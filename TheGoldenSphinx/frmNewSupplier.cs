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
    public partial class frmNewSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsTheGoldenSphinx = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        string connStr, sqlSupplier;

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            //connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsTheGoldenSphinx, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsTheGoldenSphinx, "Supplier");

            int noRows = dsTheGoldenSphinx.Tables["Supplier"].Rows.Count;

            if (noRows == 0)
            {
                lblSupplierNoGen.Text = "10001";
            }
            else
            {
                GetNumber(noRows);
            }

            errP.Clear();
            ClearForm();
        }

        public frmNewSupplier()
        {
            InitializeComponent();
        }
    }
}
