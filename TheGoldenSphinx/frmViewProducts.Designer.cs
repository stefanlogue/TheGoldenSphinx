namespace TheGoldenSphinx
{
    partial class frmViewProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvViewProductsGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnViewProductsEdit = new System.Windows.Forms.Button();
            this.btnViewProductsDelete = new System.Windows.Forms.Button();
            this.btnViewProductsCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewProductsGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvViewProductsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewProductsGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvViewProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewProductsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewProductsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewProductsGridView.DoubleBuffered = true;
            this.dgvViewProductsGridView.EnableHeadersVisualStyles = false;
            this.dgvViewProductsGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvViewProductsGridView.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvViewProductsGridView.Location = new System.Drawing.Point(12, 12);
            this.dgvViewProductsGridView.Name = "dgvViewProductsGridView";
            this.dgvViewProductsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvViewProductsGridView.Size = new System.Drawing.Size(764, 603);
            this.dgvViewProductsGridView.TabIndex = 0;
            // 
            // btnViewProductsEdit
            // 
            this.btnViewProductsEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewProductsEdit.FlatAppearance.BorderSize = 0;
            this.btnViewProductsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProductsEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductsEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewProductsEdit.Location = new System.Drawing.Point(784, 120);
            this.btnViewProductsEdit.Name = "btnViewProductsEdit";
            this.btnViewProductsEdit.Size = new System.Drawing.Size(154, 59);
            this.btnViewProductsEdit.TabIndex = 1;
            this.btnViewProductsEdit.Text = "Edit";
            this.btnViewProductsEdit.UseVisualStyleBackColor = false;
            // 
            // btnViewProductsDelete
            // 
            this.btnViewProductsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewProductsDelete.FlatAppearance.BorderSize = 0;
            this.btnViewProductsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProductsDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductsDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewProductsDelete.Location = new System.Drawing.Point(784, 217);
            this.btnViewProductsDelete.Name = "btnViewProductsDelete";
            this.btnViewProductsDelete.Size = new System.Drawing.Size(154, 59);
            this.btnViewProductsDelete.TabIndex = 2;
            this.btnViewProductsDelete.Text = "Delete";
            this.btnViewProductsDelete.UseVisualStyleBackColor = false;
            // 
            // btnViewProductsCancel
            // 
            this.btnViewProductsCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewProductsCancel.FlatAppearance.BorderSize = 0;
            this.btnViewProductsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProductsCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductsCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewProductsCancel.Location = new System.Drawing.Point(784, 314);
            this.btnViewProductsCancel.Name = "btnViewProductsCancel";
            this.btnViewProductsCancel.Size = new System.Drawing.Size(154, 59);
            this.btnViewProductsCancel.TabIndex = 3;
            this.btnViewProductsCancel.Text = "Cancel";
            this.btnViewProductsCancel.UseVisualStyleBackColor = false;
            this.btnViewProductsCancel.Click += new System.EventHandler(this.btnViewProductsCancel_Click);
            // 
            // frmViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btnViewProductsCancel);
            this.Controls.Add(this.btnViewProductsDelete);
            this.Controls.Add(this.btnViewProductsEdit);
            this.Controls.Add(this.dgvViewProductsGridView);
            this.Name = "frmViewProducts";
            this.Text = "frmViewProducts";
            this.Load += new System.EventHandler(this.frmViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewProductsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewProductsGridView;
        private System.Windows.Forms.Button btnViewProductsEdit;
        private System.Windows.Forms.Button btnViewProductsDelete;
        private System.Windows.Forms.Button btnViewProductsCancel;
    }
}