namespace TheGoldenSphinx
{
    partial class frmNewReservation
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
            this.lblReservationNoLabel = new System.Windows.Forms.Label();
            this.lblCustomerNoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmboTableNo = new System.Windows.Forms.ComboBox();
            this.cmboProductNo = new System.Windows.Forms.ComboBox();
            this.cmboCustNo = new System.Windows.Forms.ComboBox();
            this.dtReservedOn = new System.Windows.Forms.DateTimePicker();
            this.dtReservedFor = new System.Windows.Forms.DateTimePicker();
            this.lblReservationNoGen = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReservationNoLabel
            // 
            this.lblReservationNoLabel.AutoSize = true;
            this.lblReservationNoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationNoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReservationNoLabel.Location = new System.Drawing.Point(12, 9);
            this.lblReservationNoLabel.Name = "lblReservationNoLabel";
            this.lblReservationNoLabel.Size = new System.Drawing.Size(165, 24);
            this.lblReservationNoLabel.TabIndex = 0;
            this.lblReservationNoLabel.Text = "Reservation No";
            // 
            // lblCustomerNoLabel
            // 
            this.lblCustomerNoLabel.AutoSize = true;
            this.lblCustomerNoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerNoLabel.Location = new System.Drawing.Point(12, 64);
            this.lblCustomerNoLabel.Name = "lblCustomerNoLabel";
            this.lblCustomerNoLabel.Size = new System.Drawing.Size(110, 24);
            this.lblCustomerNoLabel.TabIndex = 1;
            this.lblCustomerNoLabel.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reserved On:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Meal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(214, 467);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(49, 23);
            this.txtQty.TabIndex = 11;
            // 
            // cmboTableNo
            // 
            this.cmboTableNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmboTableNo.FormattingEnabled = true;
            this.cmboTableNo.Location = new System.Drawing.Point(214, 283);
            this.cmboTableNo.Name = "cmboTableNo";
            this.cmboTableNo.Size = new System.Drawing.Size(121, 25);
            this.cmboTableNo.TabIndex = 12;
            // 
            // cmboProductNo
            // 
            this.cmboProductNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmboProductNo.FormattingEnabled = true;
            this.cmboProductNo.Location = new System.Drawing.Point(214, 403);
            this.cmboProductNo.Name = "cmboProductNo";
            this.cmboProductNo.Size = new System.Drawing.Size(121, 25);
            this.cmboProductNo.TabIndex = 13;
            // 
            // cmboCustNo
            // 
            this.cmboCustNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmboCustNo.FormattingEnabled = true;
            this.cmboCustNo.Location = new System.Drawing.Point(214, 64);
            this.cmboCustNo.Name = "cmboCustNo";
            this.cmboCustNo.Size = new System.Drawing.Size(121, 25);
            this.cmboCustNo.TabIndex = 14;
            // 
            // dtReservedOn
            // 
            this.dtReservedOn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtReservedOn.Location = new System.Drawing.Point(214, 122);
            this.dtReservedOn.Name = "dtReservedOn";
            this.dtReservedOn.Size = new System.Drawing.Size(200, 23);
            this.dtReservedOn.TabIndex = 15;
            // 
            // dtReservedFor
            // 
            this.dtReservedFor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtReservedFor.Location = new System.Drawing.Point(214, 343);
            this.dtReservedFor.Name = "dtReservedFor";
            this.dtReservedFor.Size = new System.Drawing.Size(200, 23);
            this.dtReservedFor.TabIndex = 16;
            // 
            // lblReservationNoGen
            // 
            this.lblReservationNoGen.AutoSize = true;
            this.lblReservationNoGen.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationNoGen.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReservationNoGen.Location = new System.Drawing.Point(210, 9);
            this.lblReservationNoGen.Name = "lblReservationNoGen";
            this.lblReservationNoGen.Size = new System.Drawing.Size(165, 24);
            this.lblReservationNoGen.TabIndex = 17;
            this.lblReservationNoGen.Text = "Reservation No";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(784, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 59);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(784, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 59);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblReservationNoGen);
            this.Controls.Add(this.dtReservedFor);
            this.Controls.Add(this.dtReservedOn);
            this.Controls.Add(this.cmboCustNo);
            this.Controls.Add(this.cmboProductNo);
            this.Controls.Add(this.cmboTableNo);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerNoLabel);
            this.Controls.Add(this.lblReservationNoLabel);
            this.Name = "frmNewReservation";
            this.Text = "frmNewReservation";
            this.Load += new System.EventHandler(this.frmNewReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservationNoLabel;
        private System.Windows.Forms.Label lblCustomerNoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmboTableNo;
        private System.Windows.Forms.ComboBox cmboProductNo;
        private System.Windows.Forms.ComboBox cmboCustNo;
        private System.Windows.Forms.DateTimePicker dtReservedOn;
        private System.Windows.Forms.DateTimePicker dtReservedFor;
        private System.Windows.Forms.Label lblReservationNoGen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errP;
    }
}