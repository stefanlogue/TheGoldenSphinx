using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoldenSphinx
{
    public partial class frmLandingScreen : Form
    {
        public frmLandingScreen()
        {
            InitializeComponent();
        }

        private void frmLandingScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmboLocation.SelectedItem == "Home")
            {
                Program.connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            }
            else if (cmboLocation.SelectedItem == "College")
            {
                Program.connStr = @"Data Source = .; Initial Catalog = TheGoldenSphinx; Integrated Security = true";
            }

            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void cmboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
