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
            this.lblReservationNoLabel = new System.Windows.Forms.Label();
            this.lblCustomerNoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReservationNoLabel
            // 
            this.lblReservationNoLabel.AutoSize = true;
            this.lblReservationNoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationNoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReservationNoLabel.Location = new System.Drawing.Point(36, 32);
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
            this.lblCustomerNoLabel.Location = new System.Drawing.Point(36, 89);
            this.lblCustomerNoLabel.Name = "lblCustomerNoLabel";
            this.lblCustomerNoLabel.Size = new System.Drawing.Size(146, 24);
            this.lblCustomerNoLabel.TabIndex = 1;
            this.lblCustomerNoLabel.Text = "Customer No";
            // 
            // frmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.lblCustomerNoLabel);
            this.Controls.Add(this.lblReservationNoLabel);
            this.Name = "frmNewReservation";
            this.Text = "frmNewReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservationNoLabel;
        private System.Windows.Forms.Label lblCustomerNoLabel;
    }
}