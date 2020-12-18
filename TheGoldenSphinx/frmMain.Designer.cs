namespace TheGoldenSphinx
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelStockSubMenu = new System.Windows.Forms.Panel();
            this.btnViewSuppliersForm = new System.Windows.Forms.Button();
            this.btnNewSupplierForm = new System.Windows.Forms.Button();
            this.btnViewProductsForm = new System.Windows.Forms.Button();
            this.btnNewProductForm = new System.Windows.Forms.Button();
            this.btnStockMenu = new System.Windows.Forms.Button();
            this.panelCustomerSubMenu = new System.Windows.Forms.Panel();
            this.btnViewGuestsForm = new System.Windows.Forms.Button();
            this.btnNewGuestForm = new System.Windows.Forms.Button();
            this.btnGuestMenu = new System.Windows.Forms.Button();
            this.panelHotelSubMenu = new System.Windows.Forms.Panel();
            this.btnViewRoomsForm = new System.Windows.Forms.Button();
            this.btnViewBookingsForm = new System.Windows.Forms.Button();
            this.btnNewBookingForm = new System.Windows.Forms.Button();
            this.btnHotelMenu = new System.Windows.Forms.Button();
            this.panelRestaurantSubMenu = new System.Windows.Forms.Panel();
            this.btnViewTableForm = new System.Windows.Forms.Button();
            this.btnViewReservationsForm = new System.Windows.Forms.Button();
            this.btnNewReservationForm = new System.Windows.Forms.Button();
            this.btnRestaurantMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelStockSubMenu.SuspendLayout();
            this.panelCustomerSubMenu.SuspendLayout();
            this.panelHotelSubMenu.SuspendLayout();
            this.panelRestaurantSubMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelSideMenu.Controls.Add(this.panelStockSubMenu);
            this.panelSideMenu.Controls.Add(this.btnStockMenu);
            this.panelSideMenu.Controls.Add(this.panelCustomerSubMenu);
            this.panelSideMenu.Controls.Add(this.btnGuestMenu);
            this.panelSideMenu.Controls.Add(this.panelHotelSubMenu);
            this.panelSideMenu.Controls.Add(this.btnHotelMenu);
            this.panelSideMenu.Controls.Add(this.panelRestaurantSubMenu);
            this.panelSideMenu.Controls.Add(this.btnRestaurantMenu);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 750);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelStockSubMenu
            // 
            this.panelStockSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panelStockSubMenu.Controls.Add(this.btnViewSuppliersForm);
            this.panelStockSubMenu.Controls.Add(this.btnNewSupplierForm);
            this.panelStockSubMenu.Controls.Add(this.btnViewProductsForm);
            this.panelStockSubMenu.Controls.Add(this.btnNewProductForm);
            this.panelStockSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStockSubMenu.Location = new System.Drawing.Point(0, 593);
            this.panelStockSubMenu.Name = "panelStockSubMenu";
            this.panelStockSubMenu.Size = new System.Drawing.Size(233, 159);
            this.panelStockSubMenu.TabIndex = 8;
            // 
            // btnViewSuppliersForm
            // 
            this.btnViewSuppliersForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewSuppliersForm.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliersForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliersForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewSuppliersForm.Location = new System.Drawing.Point(0, 120);
            this.btnViewSuppliersForm.Name = "btnViewSuppliersForm";
            this.btnViewSuppliersForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewSuppliersForm.Size = new System.Drawing.Size(233, 40);
            this.btnViewSuppliersForm.TabIndex = 3;
            this.btnViewSuppliersForm.Text = "View Suppliers";
            this.btnViewSuppliersForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSuppliersForm.UseVisualStyleBackColor = true;
            this.btnViewSuppliersForm.Click += new System.EventHandler(this.btnViewSuppliersForm_Click);
            // 
            // btnNewSupplierForm
            // 
            this.btnNewSupplierForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewSupplierForm.FlatAppearance.BorderSize = 0;
            this.btnNewSupplierForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSupplierForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSupplierForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnNewSupplierForm.Location = new System.Drawing.Point(0, 80);
            this.btnNewSupplierForm.Name = "btnNewSupplierForm";
            this.btnNewSupplierForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewSupplierForm.Size = new System.Drawing.Size(233, 40);
            this.btnNewSupplierForm.TabIndex = 2;
            this.btnNewSupplierForm.Text = "New Supplier";
            this.btnNewSupplierForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSupplierForm.UseVisualStyleBackColor = true;
            this.btnNewSupplierForm.Click += new System.EventHandler(this.btnNewSupplierForm_Click);
            // 
            // btnViewProductsForm
            // 
            this.btnViewProductsForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewProductsForm.FlatAppearance.BorderSize = 0;
            this.btnViewProductsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProductsForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductsForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewProductsForm.Location = new System.Drawing.Point(0, 40);
            this.btnViewProductsForm.Name = "btnViewProductsForm";
            this.btnViewProductsForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewProductsForm.Size = new System.Drawing.Size(233, 40);
            this.btnViewProductsForm.TabIndex = 1;
            this.btnViewProductsForm.Text = "View Products";
            this.btnViewProductsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewProductsForm.UseVisualStyleBackColor = true;
            this.btnViewProductsForm.Click += new System.EventHandler(this.btnViewProductsForm_Click);
            // 
            // btnNewProductForm
            // 
            this.btnNewProductForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewProductForm.FlatAppearance.BorderSize = 0;
            this.btnNewProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProductForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProductForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnNewProductForm.Location = new System.Drawing.Point(0, 0);
            this.btnNewProductForm.Name = "btnNewProductForm";
            this.btnNewProductForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewProductForm.Size = new System.Drawing.Size(233, 40);
            this.btnNewProductForm.TabIndex = 0;
            this.btnNewProductForm.Text = "New Product";
            this.btnNewProductForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProductForm.UseVisualStyleBackColor = true;
            this.btnNewProductForm.Click += new System.EventHandler(this.btnNewProductForm_Click);
            // 
            // btnStockMenu
            // 
            this.btnStockMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockMenu.FlatAppearance.BorderSize = 0;
            this.btnStockMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMenu.ForeColor = System.Drawing.Color.Gold;
            this.btnStockMenu.Location = new System.Drawing.Point(0, 548);
            this.btnStockMenu.Name = "btnStockMenu";
            this.btnStockMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStockMenu.Size = new System.Drawing.Size(233, 45);
            this.btnStockMenu.TabIndex = 7;
            this.btnStockMenu.Text = "Stock";
            this.btnStockMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockMenu.UseVisualStyleBackColor = true;
            this.btnStockMenu.Click += new System.EventHandler(this.btnStockMenu_Click);
            // 
            // panelCustomerSubMenu
            // 
            this.panelCustomerSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panelCustomerSubMenu.Controls.Add(this.btnViewGuestsForm);
            this.panelCustomerSubMenu.Controls.Add(this.btnNewGuestForm);
            this.panelCustomerSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerSubMenu.Location = new System.Drawing.Point(0, 471);
            this.panelCustomerSubMenu.Name = "panelCustomerSubMenu";
            this.panelCustomerSubMenu.Size = new System.Drawing.Size(233, 77);
            this.panelCustomerSubMenu.TabIndex = 6;
            // 
            // btnViewGuestsForm
            // 
            this.btnViewGuestsForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewGuestsForm.FlatAppearance.BorderSize = 0;
            this.btnViewGuestsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGuestsForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGuestsForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewGuestsForm.Location = new System.Drawing.Point(0, 40);
            this.btnViewGuestsForm.Name = "btnViewGuestsForm";
            this.btnViewGuestsForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewGuestsForm.Size = new System.Drawing.Size(233, 40);
            this.btnViewGuestsForm.TabIndex = 1;
            this.btnViewGuestsForm.Text = "View Guests";
            this.btnViewGuestsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGuestsForm.UseVisualStyleBackColor = true;
            // 
            // btnNewGuestForm
            // 
            this.btnNewGuestForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewGuestForm.FlatAppearance.BorderSize = 0;
            this.btnNewGuestForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGuestForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGuestForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnNewGuestForm.Location = new System.Drawing.Point(0, 0);
            this.btnNewGuestForm.Name = "btnNewGuestForm";
            this.btnNewGuestForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewGuestForm.Size = new System.Drawing.Size(233, 40);
            this.btnNewGuestForm.TabIndex = 0;
            this.btnNewGuestForm.Text = "New Guest";
            this.btnNewGuestForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGuestForm.UseVisualStyleBackColor = true;
            // 
            // btnGuestMenu
            // 
            this.btnGuestMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuestMenu.FlatAppearance.BorderSize = 0;
            this.btnGuestMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestMenu.ForeColor = System.Drawing.Color.Gold;
            this.btnGuestMenu.Location = new System.Drawing.Point(0, 426);
            this.btnGuestMenu.Name = "btnGuestMenu";
            this.btnGuestMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuestMenu.Size = new System.Drawing.Size(233, 45);
            this.btnGuestMenu.TabIndex = 5;
            this.btnGuestMenu.Text = "Guest";
            this.btnGuestMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuestMenu.UseVisualStyleBackColor = true;
            this.btnGuestMenu.Click += new System.EventHandler(this.btnGuestMenu_Click);
            // 
            // panelHotelSubMenu
            // 
            this.panelHotelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panelHotelSubMenu.Controls.Add(this.btnViewRoomsForm);
            this.panelHotelSubMenu.Controls.Add(this.btnViewBookingsForm);
            this.panelHotelSubMenu.Controls.Add(this.btnNewBookingForm);
            this.panelHotelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHotelSubMenu.Location = new System.Drawing.Point(0, 308);
            this.panelHotelSubMenu.Name = "panelHotelSubMenu";
            this.panelHotelSubMenu.Size = new System.Drawing.Size(233, 118);
            this.panelHotelSubMenu.TabIndex = 4;
            // 
            // btnViewRoomsForm
            // 
            this.btnViewRoomsForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewRoomsForm.FlatAppearance.BorderSize = 0;
            this.btnViewRoomsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRoomsForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoomsForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewRoomsForm.Location = new System.Drawing.Point(0, 80);
            this.btnViewRoomsForm.Name = "btnViewRoomsForm";
            this.btnViewRoomsForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewRoomsForm.Size = new System.Drawing.Size(233, 40);
            this.btnViewRoomsForm.TabIndex = 2;
            this.btnViewRoomsForm.Text = "Rooms";
            this.btnViewRoomsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewRoomsForm.UseVisualStyleBackColor = true;
            // 
            // btnViewBookingsForm
            // 
            this.btnViewBookingsForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewBookingsForm.FlatAppearance.BorderSize = 0;
            this.btnViewBookingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookingsForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookingsForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewBookingsForm.Location = new System.Drawing.Point(0, 40);
            this.btnViewBookingsForm.Name = "btnViewBookingsForm";
            this.btnViewBookingsForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewBookingsForm.Size = new System.Drawing.Size(233, 40);
            this.btnViewBookingsForm.TabIndex = 1;
            this.btnViewBookingsForm.Text = "View Bookings";
            this.btnViewBookingsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewBookingsForm.UseVisualStyleBackColor = true;
            // 
            // btnNewBookingForm
            // 
            this.btnNewBookingForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewBookingForm.FlatAppearance.BorderSize = 0;
            this.btnNewBookingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBookingForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBookingForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnNewBookingForm.Location = new System.Drawing.Point(0, 0);
            this.btnNewBookingForm.Name = "btnNewBookingForm";
            this.btnNewBookingForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewBookingForm.Size = new System.Drawing.Size(233, 40);
            this.btnNewBookingForm.TabIndex = 0;
            this.btnNewBookingForm.Text = "New Booking";
            this.btnNewBookingForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBookingForm.UseVisualStyleBackColor = true;
            // 
            // btnHotelMenu
            // 
            this.btnHotelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHotelMenu.FlatAppearance.BorderSize = 0;
            this.btnHotelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelMenu.ForeColor = System.Drawing.Color.Gold;
            this.btnHotelMenu.Location = new System.Drawing.Point(0, 263);
            this.btnHotelMenu.Name = "btnHotelMenu";
            this.btnHotelMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHotelMenu.Size = new System.Drawing.Size(233, 45);
            this.btnHotelMenu.TabIndex = 3;
            this.btnHotelMenu.Text = "Hotel";
            this.btnHotelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotelMenu.UseVisualStyleBackColor = true;
            this.btnHotelMenu.Click += new System.EventHandler(this.btnHotelMenu_Click);
            // 
            // panelRestaurantSubMenu
            // 
            this.panelRestaurantSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panelRestaurantSubMenu.Controls.Add(this.btnViewTableForm);
            this.panelRestaurantSubMenu.Controls.Add(this.btnViewReservationsForm);
            this.panelRestaurantSubMenu.Controls.Add(this.btnNewReservationForm);
            this.panelRestaurantSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRestaurantSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelRestaurantSubMenu.Name = "panelRestaurantSubMenu";
            this.panelRestaurantSubMenu.Size = new System.Drawing.Size(233, 118);
            this.panelRestaurantSubMenu.TabIndex = 2;
            // 
            // btnViewTableForm
            // 
            this.btnViewTableForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnViewTableForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewTableForm.FlatAppearance.BorderSize = 0;
            this.btnViewTableForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTableForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTableForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewTableForm.Location = new System.Drawing.Point(0, 80);
            this.btnViewTableForm.Name = "btnViewTableForm";
            this.btnViewTableForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewTableForm.Size = new System.Drawing.Size(233, 40);
            this.btnViewTableForm.TabIndex = 2;
            this.btnViewTableForm.Text = "Tables";
            this.btnViewTableForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTableForm.UseVisualStyleBackColor = false;
            this.btnViewTableForm.Click += new System.EventHandler(this.btnViewTableForm_Click);
            // 
            // btnViewReservationsForm
            // 
            this.btnViewReservationsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnViewReservationsForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewReservationsForm.FlatAppearance.BorderSize = 0;
            this.btnViewReservationsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReservationsForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservationsForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewReservationsForm.Location = new System.Drawing.Point(0, 40);
            this.btnViewReservationsForm.Name = "btnViewReservationsForm";
            this.btnViewReservationsForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewReservationsForm.Size = new System.Drawing.Size(233, 40);
            this.btnViewReservationsForm.TabIndex = 1;
            this.btnViewReservationsForm.Text = "View Reservations";
            this.btnViewReservationsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReservationsForm.UseVisualStyleBackColor = false;
            this.btnViewReservationsForm.Click += new System.EventHandler(this.btnViewReservationsForm_Click);
            // 
            // btnNewReservationForm
            // 
            this.btnNewReservationForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNewReservationForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewReservationForm.FlatAppearance.BorderSize = 0;
            this.btnNewReservationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReservationForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReservationForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnNewReservationForm.Location = new System.Drawing.Point(0, 0);
            this.btnNewReservationForm.Name = "btnNewReservationForm";
            this.btnNewReservationForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewReservationForm.Size = new System.Drawing.Size(233, 40);
            this.btnNewReservationForm.TabIndex = 0;
            this.btnNewReservationForm.Text = "New Reservation";
            this.btnNewReservationForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewReservationForm.UseVisualStyleBackColor = false;
            this.btnNewReservationForm.Click += new System.EventHandler(this.btnNewReservationForm_Click);
            // 
            // btnRestaurantMenu
            // 
            this.btnRestaurantMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurantMenu.FlatAppearance.BorderSize = 0;
            this.btnRestaurantMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurantMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurantMenu.ForeColor = System.Drawing.Color.Gold;
            this.btnRestaurantMenu.Location = new System.Drawing.Point(0, 100);
            this.btnRestaurantMenu.Name = "btnRestaurantMenu";
            this.btnRestaurantMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRestaurantMenu.Size = new System.Drawing.Size(233, 45);
            this.btnRestaurantMenu.TabIndex = 1;
            this.btnRestaurantMenu.Text = "Restaurant";
            this.btnRestaurantMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurantMenu.UseVisualStyleBackColor = true;
            this.btnRestaurantMenu.Click += new System.EventHandler(this.btnRestaurantMenu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelTitleBar.Controls.Add(this.btnX);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(950, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(950, 650);
            this.panelChildForm.TabIndex = 2;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.DarkRed;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnX.Location = new System.Drawing.Point(908, -6);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(48, 42);
            this.btnX.TabIndex = 5;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.btnX;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelStockSubMenu.ResumeLayout(false);
            this.panelCustomerSubMenu.ResumeLayout(false);
            this.panelHotelSubMenu.ResumeLayout(false);
            this.panelRestaurantSubMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelRestaurantSubMenu;
        private System.Windows.Forms.Button btnViewTableForm;
        private System.Windows.Forms.Button btnViewReservationsForm;
        private System.Windows.Forms.Button btnNewReservationForm;
        private System.Windows.Forms.Button btnRestaurantMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelStockSubMenu;
        private System.Windows.Forms.Button btnNewSupplierForm;
        private System.Windows.Forms.Button btnViewProductsForm;
        private System.Windows.Forms.Button btnNewProductForm;
        private System.Windows.Forms.Button btnStockMenu;
        private System.Windows.Forms.Panel panelCustomerSubMenu;
        private System.Windows.Forms.Button btnViewGuestsForm;
        private System.Windows.Forms.Button btnNewGuestForm;
        private System.Windows.Forms.Button btnGuestMenu;
        private System.Windows.Forms.Panel panelHotelSubMenu;
        private System.Windows.Forms.Button btnViewRoomsForm;
        private System.Windows.Forms.Button btnViewBookingsForm;
        private System.Windows.Forms.Button btnNewBookingForm;
        private System.Windows.Forms.Button btnHotelMenu;
        private System.Windows.Forms.Button btnViewSuppliersForm;
        private System.Windows.Forms.Panel panelTitleBar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnX;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}

