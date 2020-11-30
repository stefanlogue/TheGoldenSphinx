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
    public partial class frmMain : Form
    {
        private Form activeForm = null;
        public frmMain()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            panelRestaurantSubMenu.Visible = false;
            panelHotelSubMenu.Visible = false;
            panelCustomerSubMenu.Visible = false;
            panelStockSubMenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (panelRestaurantSubMenu.Visible == true)
                panelRestaurantSubMenu.Visible = false;
            if (panelHotelSubMenu.Visible == true)
                panelHotelSubMenu.Visible = false;
            if (panelCustomerSubMenu.Visible == true)
                panelCustomerSubMenu.Visible = false;
            if (panelStockSubMenu.Visible == true)
                panelStockSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnStockMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStockSubMenu);
        }

        private void btnRestaurantMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelRestaurantSubMenu);
        }

        private void btnHotelMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelHotelSubMenu);
        }

        private void btnGuestMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCustomerSubMenu);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if (activeForm.GetType() != childForm.GetType())
                {
                    activeForm.Close();
                    activeForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    panelChildForm.Controls.Add(childForm);
                    panelChildForm.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void btnNewReservationForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNewReservation());
        }

        private void btnViewReservationsForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewReservations());
        }

        private void btnViewProductsForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewProducts());
        }

        private void btnViewSuppliersForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewSuppliers());
        }
    }
}
