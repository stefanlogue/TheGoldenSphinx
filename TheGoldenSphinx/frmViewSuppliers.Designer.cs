namespace TheGoldenSphinx
{
    partial class frmViewSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvViewSuppliersGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnViewSuppliersCancel = new System.Windows.Forms.Button();
            this.btnViewSuppliersDelete = new System.Windows.Forms.Button();
            this.btnViewSuppliersEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSuppliersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewSuppliersGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvViewSuppliersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewSuppliersGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvViewSuppliersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewSuppliersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewSuppliersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewSuppliersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSuppliersGridView.DoubleBuffered = true;
            this.dgvViewSuppliersGridView.EnableHeadersVisualStyles = false;
            this.dgvViewSuppliersGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvViewSuppliersGridView.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvViewSuppliersGridView.Location = new System.Drawing.Point(12, 12);
            this.dgvViewSuppliersGridView.Name = "dgvViewSuppliersGridView";
            this.dgvViewSuppliersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvViewSuppliersGridView.Size = new System.Drawing.Size(764, 603);
            this.dgvViewSuppliersGridView.TabIndex = 1;
            // 
            // btnViewSuppliersCancel
            // 
            this.btnViewSuppliersCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewSuppliersCancel.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliersCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliersCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliersCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewSuppliersCancel.Location = new System.Drawing.Point(784, 314);
            this.btnViewSuppliersCancel.Name = "btnViewSuppliersCancel";
            this.btnViewSuppliersCancel.Size = new System.Drawing.Size(154, 59);
            this.btnViewSuppliersCancel.TabIndex = 6;
            this.btnViewSuppliersCancel.Text = "Cancel";
            this.btnViewSuppliersCancel.UseVisualStyleBackColor = false;
            this.btnViewSuppliersCancel.Click += new System.EventHandler(this.btnViewSuppliersCancel_Click);
            // 
            // btnViewSuppliersDelete
            // 
            this.btnViewSuppliersDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewSuppliersDelete.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliersDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliersDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliersDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewSuppliersDelete.Location = new System.Drawing.Point(784, 217);
            this.btnViewSuppliersDelete.Name = "btnViewSuppliersDelete";
            this.btnViewSuppliersDelete.Size = new System.Drawing.Size(154, 59);
            this.btnViewSuppliersDelete.TabIndex = 5;
            this.btnViewSuppliersDelete.Text = "Delete";
            this.btnViewSuppliersDelete.UseVisualStyleBackColor = false;
            // 
            // btnViewSuppliersEdit
            // 
            this.btnViewSuppliersEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewSuppliersEdit.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliersEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliersEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliersEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewSuppliersEdit.Location = new System.Drawing.Point(784, 120);
            this.btnViewSuppliersEdit.Name = "btnViewSuppliersEdit";
            this.btnViewSuppliersEdit.Size = new System.Drawing.Size(154, 59);
            this.btnViewSuppliersEdit.TabIndex = 4;
            this.btnViewSuppliersEdit.Text = "Edit";
            this.btnViewSuppliersEdit.UseVisualStyleBackColor = false;
            // 
            // frmViewSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btnViewSuppliersCancel);
            this.Controls.Add(this.btnViewSuppliersDelete);
            this.Controls.Add(this.btnViewSuppliersEdit);
            this.Controls.Add(this.dgvViewSuppliersGridView);
            this.Name = "frmViewSuppliers";
            this.Text = "frmViewSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSuppliersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewSuppliersGridView;
        private System.Windows.Forms.Button btnViewSuppliersCancel;
        private System.Windows.Forms.Button btnViewSuppliersDelete;
        private System.Windows.Forms.Button btnViewSuppliersEdit;
    }
}